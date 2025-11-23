using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PickleballApp.Models;

namespace PickleballApp.Controllers
{
    public class PlayerController : Controller
    {

        private PlayerContext Context { get; set; }

        // constructor method
        public PlayerController(PlayerContext context)
        {
            Context = context;
        }
        
        // GET: PlayerController
        public IActionResult Index()
        {
            //querying the database to return ALL players ordered by Last name
            List<Player> players =
                Context.Players
                .OrderBy(m => m.LastName)
                .ToList();

            return View(players);
        }


        // GET: PlayerController/Create
        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Edit";

            return View("Edit", new Player());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            var player = Context.Players.Find(id);

            return View(player);
        }

        [HttpPost]
        public IActionResult Edit(Player player)
        {
            if (ModelState.IsValid)
            {
                if(player.PlayerId == 0)
                {
                    Context.Players.Add(player);
                }
                else
                {
                    Context.Players.Update(player);
                }

                Context.SaveChanges();

                return RedirectToAction("Index", "Player");
            }
            else
            {
                ViewBag.Action = (player.PlayerId == 0) ? "Add" : "Edit";

                return View(player);
            }
        }

        // GET: PlayerController/Delete/5
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var player = Context.Players.Find(id);


            return View(player);
        }

        // POST: PlayerController/Delete/5
        [HttpPost]
        public IActionResult Delete(Player player)
        {
            Context.Players.Remove(player);
            Context.SaveChanges();

            return RedirectToAction("Index", "Player");
        }
    }
}
