using System;
using System.Collections.Generic;
using System.Linq;

namespace MovieListProject
{
    class MoviesMain
    {
        static void Main(string[] args)
        {
            List<Movies> movies = AddMovieList();
            //interface logic for userinput
            Console.WriteLine("What movie category are you interested in browsing?");
            string category = Console.ReadLine();
            bool isNotNullCategory = string.IsNullOrEmpty(category);
            if (isNotNullCategory == true)
            {
                List<Movies> moviesReturn = GetMovieCategory(movies, category);
                foreach (var item in moviesReturn)
                {
                    Console.WriteLine(item.MovieTitle);
                }
            }
            else
            {
                Console.WriteLine("The valid categories are: SciFi\n, Romance\n, Comedy\n, High Fantasy\n, Action\n, Adventure");
            }
            Console.ReadKey();
        }

        public static List<Movies> AddMovieList()
        {
            List<Movies> movieList = new List<Movies>();
            movieList.Add(new Movies("Dune", MovieCategories.SciFi));
            movieList.Add(new Movies("The Eternals", MovieCategories.Action));
            movieList.Add(new Movies("Lord of the Rings", MovieCategories.HighFantasy));
            movieList.Add(new Movies("Bruce Almighty", MovieCategories.Comedy));
            movieList.Add(new Movies("Moonlight", MovieCategories.Romance));
            movieList.Add(new Movies("Indiana Jones and the Temple of Doom", MovieCategories.Adventure));
            movieList.Add(new Movies("Star Wars: The Empire Strikes Back", MovieCategories.SciFi));
            movieList.Add(new Movies("Die Hard", MovieCategories.Action));
            movieList.Add(new Movies("The Mask", MovieCategories.Comedy));
            movieList.Add(new Movies("Steel Magnolias", MovieCategories.Romance));

            return movieList;
        }

        public static List<Movies> GetMovieCategory(List<Movies> movieList, string category)
        {
            List<Movies> matchingMovies = new List<Movies>();
            foreach (var item in movieList)
            {
                if (item.MovieCategory.ToString() == category)
                {
                    matchingMovies.Add(item);
                }
            }
            return matchingMovies;
        }
    
    }
}
