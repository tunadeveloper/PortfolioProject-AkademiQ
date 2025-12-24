using Microsoft.AspNetCore.Mvc;
using PortfolioProject_AkademiQ.Data;
using PortfolioProject_AkademiQ.Entities;

namespace PortfolioProject_AkademiQ.Controllers
{
    public class EducationController : Controller
    {
        private readonly AppDbContext _context;

        public EducationController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var values = _context.Educations.ToList();
            return View(values);
        }

        public IActionResult CreateEducation() => View();

        [HttpPost]
        public IActionResult CreateEducation(Education education)
        {
            var values = _context.Educations.Add(education);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteEducation(int id)
        {
            var values = _context.Educations.Find(id);
            _context.Educations.Remove(values);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult UpdateEducation(int id)
        {
            var values = _context.Educations.Find(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateEducation(Education education)
        {
            var values = _context.Educations.Find(education.EducationId);
            values.Department = education.Department;
            values.Title = education.Title;
            values.EducationDate = education.EducationDate;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
