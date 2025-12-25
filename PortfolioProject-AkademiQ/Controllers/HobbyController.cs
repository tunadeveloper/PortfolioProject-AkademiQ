using Microsoft.AspNetCore.Mvc;
using PortfolioProject_AkademiQ.Data;
using PortfolioProject_AkademiQ.Entities;

namespace PortfolioProject_AkademiQ.Controllers
{
    public class HobbyController : Controller
    {
        private readonly AppDbContext _context;

        public HobbyController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var values = _context.Hobbies.ToList();
            return View(values);
        }

        public IActionResult DeleteHobby(int id)
        {
            if (ModelState.IsValid)
            {
                var values = _context.Hobbies.Find(id);
                _context.Hobbies.Remove(values);
                _context.SaveChanges();
                TempData["Delete"] = "Hobi başarıyla silindi!";
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult CreateHobby() => View();

        [HttpPost]
        public IActionResult CreateHobby(Hobby hobby)
        {
            if (!ModelState.IsValid)
                return View(hobby);

            _context.Hobbies.Add(hobby);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }


        public IActionResult UpdateHobby(int id)
        {
            var hobby = _context.Hobbies.Find(id);
            return View(hobby);
        }

        [HttpPost]
        public IActionResult UpdateHobby(Hobby hobby)
        {
            var updatedHobby = _context.Hobbies.Find(hobby.HobbyId);
            updatedHobby.Title = hobby.Title;
            updatedHobby.IconUrl = hobby.IconUrl;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
