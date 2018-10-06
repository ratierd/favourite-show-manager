using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavouriteShowManager.Model
{
    public class Serie : Show
    {

        private int _seasonNumber;
        public int SeasonNumber { get { return _seasonNumber; } }

        public Serie(String title, String synopsis, String posterUrl, String year, String actors, String language) : base(title, synopsis, posterUrl, year, actors, language) { }

        public Serie(String title, String synopsis, String posterUrl, String year, String actors, String language, int seasonNumber) : base(title, synopsis, posterUrl, year, actors, language)
        {
            _seasonNumber = seasonNumber;
        }

    }
}
