using Lab1.Data;
using Lab1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab1.Controllers
{
    public class MovieController : Controller
    {
        
        [HttpGet]
        public IActionResult GetMovieInfo(int id)
        {
           Movie? movie= FakeContext.Movies.FirstOrDefault<Movie>(c => c.MovieId == id);
            return View("Index", movie);
        }


        [HttpGet]
        //GetAllInGenre?genre=Comedy
        public IActionResult GetAllInGenre(string genre)
        {
            List<Movie> movies = FakeContext.Movies.Where(c => c.Genre==genre).ToList<Movie>(); 
            return View("AllMovie",movies);
        }

        [HttpGet]
        //getCountinGenre?genre=Comedy
        public IActionResult GetCountInGenre(string genre)
        {
            int count = FakeContext.Movies.Where(c => c.Genre == genre).ToList<Movie>().Count();
            ViewBag.Genre = genre;
            ViewBag.Count = count;
            return View();
        }

        [HttpGet]
        ///moviesinbudget?budget=100
        public IActionResult MoviesInBudget(int budget)
        {
            List<Movie> movies = FakeContext.Movies.Where(c => c.Budget == budget).ToList<Movie>();
        
            return View(movies);
        }

        [HttpGet]
        ///MoviesInThe90s?years=90
        public IActionResult MoviesInThe90s(int years)
        {
            List<Movie> movies = FakeContext.Movies.Where(c => c.Years == years).ToList<Movie>();

            return View("MoviesInBudget", movies);
        }

        [HttpGet]
        public IActionResult CalculateOverallRating()
        {
            int  sum = FakeContext.Rates.Sum(c=>c.Level);
            ViewBag.Sum = sum;
            return View();
        }
        

    }
}
