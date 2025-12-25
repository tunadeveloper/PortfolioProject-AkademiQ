using Microsoft.AspNetCore.Mvc;
using PortfolioProject_AkademiQ.Data;
using PortfolioProject_AkademiQ.Entities;

namespace PortfolioProject_AkademiQ.Controllers
{
    public class AboutController : Controller
    {
        private readonly AppDbContext _context;

        public AboutController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult UpdateAbout(int id = 1)
        {
            var values = _context.Abouts.Find(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateAbout(About about)
        {
            if (ModelState.IsValid)
            {
                _context.Abouts.Update(about);
                _context.SaveChanges();
                TempData["Update"] = "Bilgiler başarıyla güncellendi!";
                return Redirect("/About/UpdateAbout/1");
            }
            return View(about);
        }
    }
}
