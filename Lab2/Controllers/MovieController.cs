using Lab2.Data;
using Lab2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab2.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetAllMovies()
        {

            return View(Context.movies.ToList<Movie>());
        }
        public IActionResult MovieDetails(int id)
        {
            ViewBag.MovieId = id;
            List<Role> roles=Context.roles.Where(c=>c.Movie.MovieId==id).ToList<Role>(); 
            return View(roles);
        }
        public IActionResult CreateCommentView(int movieId,int type)
        {
            ViewBag.MovieId = movieId;
            ViewBag.Type = type;
            return View();
        }

        [HttpPost]
        public IActionResult CreateCommentView(Rating rating,int id,int type)
        {
            if (rating.User.Name == rating.UserName)
            {
                return NotFound();
            }
             rating.RatingId = Context.ratings.Count + 1;
             rating.RatedId = id;
             rating.Type = type;
             rating.User = Context.users.FirstOrDefault<User>(c=>c.Name==rating.UserName);
             Context.ratings.Add(rating);

             
             return RedirectToAction("MovieDetails", "Movie", new { id = id});
        }
        
    }
}
