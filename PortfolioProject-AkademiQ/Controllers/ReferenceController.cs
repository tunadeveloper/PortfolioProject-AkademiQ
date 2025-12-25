using Microsoft.AspNetCore.Mvc;
using PortfolioProject_AkademiQ.Data;
using PortfolioProject_AkademiQ.Entities;

namespace PortfolioProject_AkademiQ.Controllers
{
    public class ReferenceController : Controller
    {
        private readonly AppDbContext _context;

        public ReferenceController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var values = _context.References.ToList();
            return View(values);
        }

        public IActionResult DeleteReference(int id)
        {
            if (ModelState.IsValid)
            {
                var values = _context.References.Find(id);
                _context.References.Remove(values);
                _context.SaveChanges();
                TempData["Delete"] = "Referans başarıyla silindi!";
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult CreateReference() => View();

        [HttpPost]
        public IActionResult CreateReference(Reference reference)
        {
                        _context.References.Add(reference);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult UpdateReference(int id)
        {
            var values = _context.References.Find(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateReference(Reference reference)
        {
            var values = _context.References.Find(reference.ReferenceId);
            values.NameSurname = reference.NameSurname;
            values.Title = reference.Title;
            values.ImageUrl = reference.ImageUrl;
            values.Comment = reference.Comment;
            values.LinkedInUrl = reference.LinkedInUrl;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
