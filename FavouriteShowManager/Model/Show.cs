using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavouriteShowManager.Model
{
    public abstract class Show
    {
        public enum ShowState { SEEN, TO_SEE, CONSIDERED }

        protected String _title;
        public String Title { get { return _title; } }
        protected String _synopsis;
        public String Synopsis { get { return _synopsis; } }
        protected String _posterUrl;
        public String PosterUrl { get { return _posterUrl; } }
        protected String _year;
        public String Year { get { return _year; } }
        protected bool _saved;
        public bool Saved { get { return _saved; } set { _saved = value; } }
        protected ShowState _state;
        public ShowState State { get { return _state; } set { _state = value; } }
        protected List<String> _categories;
        public List<String> Categories { get { return _categories; } }
        private String _actors;
        public String Actors { get { return _actors; } }
        private String _language;
        public String Language { get { return _language; } }

        private String _userComment;
        public String UserComment { get { return _userComment; } set { _userComment = value; } }

        public Show(String title, String synopsis, String posterUrl, String year, String actors, String language)
        {
            _title = title;
            _synopsis = synopsis;
            _posterUrl = posterUrl;
            _year = year;
            _saved = false;
            _categories = new List<string>();
            _actors = actors;
            _language = language;

            _userComment = "";
        }

        public void AddCategory(String category)
        {
            _categories.Add(category);
        }

        public void RemoveCategory(String category)
        {
            _categories.Remove(category);
        }

        public void ToggleSave()
        {
            _saved = !_saved;
        }

    }
}
