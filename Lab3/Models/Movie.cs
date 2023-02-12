namespace Lab3.Models
{
    public class Movie
    {
        private int _movieId;
        public int MovieId { get { return _movieId; } }

        private string _title;
        public string Title { get { return _title; } }

        private string _genre;
        public string Genre { get { return _genre; } }


        private int _budget;
        public int Budget { get { return _budget; } }

        private int _years;
        public int Years { get { return _years; } }



        public Movie(int movieId, string title, string genre, int budget, int years)
        {
            _movieId = movieId;
            _title = title;
            _genre = genre;
            _budget = budget;
            _years = years;
        }
    }
}
