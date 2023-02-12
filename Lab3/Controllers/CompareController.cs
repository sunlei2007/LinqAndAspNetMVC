using Lab3.Data;
using Lab3.Models;
using Lab3.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace Lab3.Controllers
{
    public class CompareController : Controller
    {
        public IActionResult Index()
        {
            CompareVM vm = new CompareVM(Context.movies);
            return View(vm);
        }
        [HttpPost]
        public IActionResult Index([Bind("MovieId1", "MovieId2")] CompareVM vm, string secret)
        {
            if (vm.MovieId1 == vm.MovieId2)
            {
                return NotFound();
            }


            return RedirectToAction("CompareResult", "Compare", new { id1 = vm.MovieId1, id2 = vm.MovieId2 });
        }
        [HttpGet]
        public IActionResult CompareResult(int id1, int id2)
        {
            Movie? movie1 = Context.movies.FirstOrDefault(c => c.MovieId == id1);
            Movie? movie2 = Context.movies.FirstOrDefault(c => c.MovieId == id2);
            CompareResult compareResult = new CompareResult(movie1, movie2);

            return View(compareResult);
        }
    }
}
