using FavouriteShowManager.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FavouriteShowManager.Model;
using System.Net;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.IO;
using static FavouriteShowManager.View.StateFilter;

namespace FavouriteShowManager.Controller
{
    public enum BasicActions { SEARCH, ALL }

    public interface IAction
    {
        List<Control> action();
    }

    public class SearchAction : IAction
    {
        private SearchBar searchBar;
        private ShowList resultList;
        private int page;

        public List<Control> action()
        {
            page = 1;
            List<Control> result = new List<Control>();
            searchBar = new SearchBar();
            resultList = new ShowList(new List<ShowListItem>());
            searchBar.SearchSubmitted += searchBar_searchSubmitted;
            result.Add(resultList);
            result.Add(searchBar);
            return result;
        }

        private void searchBar_searchSubmitted(object sender, SearchBar.SearchSubmittedEventArgs args)
        {
            WebClient client = new WebClient();
            JObject APIResponse = JObject.Parse(client.DownloadString("http://www.omdbapi.com/?s=" + args.SearchTerm.Replace(' ', '+') + "&page=" + page));
            List<ShowListItem> searchResults = new List<ShowListItem>();
            if(APIResponse["Search"] != null)
            {
                foreach (JToken o in APIResponse["Search"].Children())
                {
                    Show s = null;
                    if(o != null)
                    {
                        try
                        {
                            JToken showDetails = JObject.Parse(client.DownloadString("http://www.omdbapi.com/?i=" + o["imdbID"])).Root;
                            switch ((string)showDetails["Type"])
                            {
                                case "series":
                                    if (showDetails.Contains("totalSeasons"))
                                    {
                                        s = new Serie((string)showDetails["Title"], (string)showDetails["Plot"], (string)showDetails["Poster"], (string)showDetails["Year"], (string)showDetails["Actors"], (string)showDetails["Language"], (int)showDetails["totalSeasons"]);
                                    }
                                    else
                                    {
                                        s = new Serie((string)showDetails["Title"], (string)showDetails["Plot"], (string)showDetails["Poster"], (string)showDetails["Year"], (string)showDetails["Actors"], (string)showDetails["Language"]);
                                    }
                                    break;
                                case "movie":
                                    s = new Movie((string)showDetails["Title"], (string)showDetails["Plot"], (string)showDetails["Poster"], (string)showDetails["Year"], (string)showDetails["Actors"], (string)showDetails["Language"]);
                                    break;
                            }
                        }
                        catch (Exception e)
                        {
                            System.Console.WriteLine("error : " + e.Message);
                        }
                    }
                    if (s != null)
                    {
                        searchResults.Add(new ShowListItem(s));
                    }
                }
            }
            searchResults.Reverse();
            resultList.Controls.Clear();
            resultList.Controls.AddRange(searchResults.ToArray());
            Program.window.ToolStripStatusLabel.Text = searchResults.Count + " results found";
            Program.window.StatusStrip.Refresh();
        }
    }

    public class AllAction : IAction
    {
        private ShowList showListControl;
        private StateFilter stateFilterControl;

        public List<Control> action()
        {
            List<ShowListItem> showList = new List<ShowListItem>();
            foreach(Show s in Window.controller.allShows())
            {
                showList.Add(new ShowListItem(s));
            }
            List<Control> result = new List<Control>();

            showListControl = new ShowList(showList);
            stateFilterControl = new StateFilter();
            stateFilterControl.Dock = DockStyle.Top;
            stateFilterControl.FiltersChanged += stateFilter_filtersChanged;

            result.Add(showListControl);
            result.Add(stateFilterControl);

            return result;
        }

        private void stateFilter_filtersChanged(object sender, FiltersChangedEventArgs e)
        {
            showListControl.filterList(e.Filters);
        }
    }

    public class CategoryAction : IAction
    {
        public String category;

        public CategoryAction(String category)
        {
            this.category = category;
        }

        private ShowList showListControl;
        private StateFilter stateFilterControl;

        public List<Control> action()
        {
            List<ShowListItem> showList = new List<ShowListItem>();
            foreach (Show s in Window.controller.showsByCategory(this.category))
            {
                showList.Add(new ShowListItem(s));
            }
            List<Control> result = new List<Control>();

            showListControl = new ShowList(showList);
            stateFilterControl = new StateFilter();
            stateFilterControl.Dock = DockStyle.Top;
            stateFilterControl.FiltersChanged += stateFilter_filtersChanged;

            result.Add(showListControl);
            result.Add(stateFilterControl);

            return result;
        }

        private void stateFilter_filtersChanged(object sender, FiltersChangedEventArgs e)
        {
            showListControl.filterList(e.Filters);
        }
    }

    public class ShowController
    {

        private List<Show> _shows;
        public List<Show> Shows { get { return _shows; } }

        private JsonSerializer serializer;

        public ShowController()
        {
            _shows = new List<Show>();

            serializer = new JsonSerializer();
            serializer.TypeNameHandling = TypeNameHandling.Objects;
            using (StreamReader sw = new StreamReader(@"./json.txt"))
            using (JsonReader reader = new JsonTextReader(sw))
            {
                _shows = (List<Show>)serializer.Deserialize(reader, _shows.GetType());
            }
            Console.WriteLine(_shows);
        }

        public Control showDetailsView(Show showItem)
        {
            return new ShowDetails(showItem);
        }

        public List<Show> allShows()
        {
            List<Show> result = Shows.GetRange(0, Shows.Count);
            result.Reverse();
            return result;
        }

        public List<Show> showsByCategory(String category)
        {
            List<Show> result = Shows.FindAll(delegate (Show s)
            {
                return s.Categories.Contains(category);
            });
            result.Reverse();
            return result;
        }

        public void saveShow(Show show)
        {
            _shows.Add(show);
            show.Saved = true;
            recordState();
        }

        public void removeShow(Show show)
        {
            _shows.Remove(show);
            show.Saved = false;
            show.Categories.Clear();
            show.State = Show.ShowState.TO_SEE;
            show.UserComment = "";
            recordState();
        }

        public bool showIsSaved(Show show)
        {
            bool result = false;
            _shows.ForEach(delegate (Show s)
            {
                result |= s.Title == show.Title && s.Saved;
            });
            return result;
        }

        public void recordState()
        {
            using (StreamWriter sw = new StreamWriter(@"./json.txt"))
            using(JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, _shows);
            }
        }
    }
}
