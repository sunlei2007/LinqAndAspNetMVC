using Lab1.Models;

namespace Lab1.Data
{
    public static class FakeContext
    {
        public static HashSet<Movie> Movies = new HashSet<Movie>();
        public static HashSet<Actor> Actors = new HashSet<Actor>();
        public static HashSet<Rating> Rates = new HashSet<Rating>();

        private static int _idCounter = 1;

        static FakeContext()
        {
            // "Seed Method"
            Movies.Add(new Movie(_idCounter++,"Movie1", "Comedy",100,80));
            Movies.Add(new Movie(_idCounter++, "Movie2", "Comedy", 120, 90));
            Movies.Add(new Movie(_idCounter++, "Movie3", "Adventure", 130, 90));
            Movies.Add(new Movie(_idCounter++, "Movie4", "Adventure", 150, 90));

            Actors.Add(new Actor(_idCounter++, "Actor1", 100));
            Actors.Add(new Actor(_idCounter++, "Actor2", 200));
            Actors.Add(new Actor(_idCounter++, "Actor3", 300));
            Actors.Add(new Actor(_idCounter++, "Actor4", 400));

            Rates.Add(new Rating(_idCounter, 10));
            Rates.Add(new Rating(_idCounter, 8));
            Rates.Add(new Rating(_idCounter, 7));
            Rates.Add(new Rating(_idCounter, 6));
            Rates.Add(new Rating(_idCounter, 5));
        }
    }
}
