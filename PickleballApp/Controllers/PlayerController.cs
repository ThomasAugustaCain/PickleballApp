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

        // GET: PlayerController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PlayerController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PlayerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PlayerController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PlayerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
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
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
