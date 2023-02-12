using Microsoft.AspNetCore.Mvc.Rendering;

namespace Lab3.Models.ViewModel
{
    public class CompareVM
    {
        public List<SelectListItem> Movies1 { get; } = new List<SelectListItem>();
        public List<SelectListItem> Movies2 { get; } = new List<SelectListItem>();
        
        public string MovieId1 { get; set; }
        public string MovieId2 { get; set; }


        public CompareVM(HashSet<Movie> movies)
        {
            foreach (Movie a in movies)
            {
                Movies1.Add(new SelectListItem(a.Title, a.MovieId.ToString()));
            }

            foreach (Movie a in movies)
            {
                Movies2.Add(new SelectListItem(a.Title, a.MovieId.ToString()));
            }
        }
        public CompareVM() { }
         
    }
}
