using Lab1.Data;
using Lab1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Lab1.Controllers
{
    public class ActorController : Controller
    {
        
        [HttpGet]
        public IActionResult HighestPaidActor()
        {
           int maxPaid= FakeContext.Actors.Max(c => c.Paid);
            var actors = FakeContext.Actors.Where(c => c.Paid == maxPaid).ToList<Actor>();
   
            return View("Index", actors);
        }

        [HttpGet]
        public IActionResult HighestPaidActorByOrder()
        {
            
            var actor = FakeContext.Actors.OrderByDescending(c=>c.Paid).FirstOrDefault();

            return View( actor);
        }


    }
}
