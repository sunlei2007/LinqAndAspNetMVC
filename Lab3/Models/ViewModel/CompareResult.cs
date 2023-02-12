namespace Lab3.Models.ViewModel
{
    public class CompareResult
    {
        public  HashSet<Movie> movies1 = new HashSet<Movie>();
        public  HashSet<Movie> movies2 = new HashSet<Movie>();

        public  CompareResult(Movie movie1,Movie movie2) 
        {
            movies1.Add(movie1);
            movies2.Add(movie2);    
        }
    }
}
