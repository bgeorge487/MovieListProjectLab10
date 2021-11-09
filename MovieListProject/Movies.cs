using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieListProject
{
    class Movies
    {
        private string movieTitle;
        public string MovieTitle
        {
            get { return movieTitle; }
            set { movieTitle = value; }
        }

        private MovieCategories movieCategory;
        public MovieCategories MovieCategory
        {
            get { return movieCategory; }
            set { movieCategory = value; }
        }

        public Movies(string title, MovieCategories category)
        {
            MovieTitle = title;
            MovieCategory = category;
        }

        
    }
}
