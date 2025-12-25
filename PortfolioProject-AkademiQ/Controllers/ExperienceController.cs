using Microsoft.AspNetCore.Mvc;
using PortfolioProject_AkademiQ.Data;
using PortfolioProject_AkademiQ.Entities;

namespace PortfolioProject_AkademiQ.Controllers
{
    public class ExperienceController : Controller
    {
        private readonly AppDbContext _context;

        public ExperienceController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var values = _context.Experiences.ToList();
            return View(values);
        }

        public IActionResult CreateExperience() => View();

        [HttpPost]
        public IActionResult CreateExperience(Experience experience)
        {
            _context.Experiences.Add(experience);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteExperience(int id)
        {
            if (ModelState.IsValid)
            {
                var values = _context.Experiences.Find(id);
                _context.Experiences.Remove(values);
                _context.SaveChanges();
                TempData["Delete"] = "Deneyim başarıyla silindi!";
                return RedirectToAction("Index");
            }
           return View();
        }

        public IActionResult UpdateExperience(int id)
        {
            var values = _context.Experiences.Find(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateExperience(Experience experience)
        {
            var values = _context.Experiences.Find(experience.ExperienceId);
            values.CompanyName = experience.CompanyName;
            values.WorkDate = experience.WorkDate;
            values.Title = experience.Title;
            values.Description = experience.Description;
            values.IconUrl = experience.IconUrl;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
