using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavouriteShowManager.Model
{
    public class Movie : Show
    {

        public Movie(String title, String synopsis, String posterUrl, String year, String actors, String language) : base(title, synopsis, posterUrl, year, actors, language)
        {
            
        }

    }
}
