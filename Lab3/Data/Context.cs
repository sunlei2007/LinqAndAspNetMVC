using Lab3.Models;
using System.Data;
using System.Diagnostics.Metrics;

namespace Lab3.Data
{
    public static class Context
    {
       public static HashSet<Movie> movies = new HashSet<Movie>();
        private static int idCounter = 0;
        static Context()
        {
            Movie movie1 = new Movie(idCounter++, "Movie1", "Comedy", 100, 80);
            Movie movie2 = new Movie(idCounter++, "Movie2", "Comedy", 120, 90);
            Movie movie3 = new Movie(idCounter++, "Movie3", "Adventure", 130, 90);
            Movie movie4 = new Movie(idCounter++, "Movie4", "Adventure", 150, 90);

          
            movies.Add(movie1);
            movies.Add(movie2);
            movies.Add(movie3);
            movies.Add(movie4);
 
        }
    }
}
