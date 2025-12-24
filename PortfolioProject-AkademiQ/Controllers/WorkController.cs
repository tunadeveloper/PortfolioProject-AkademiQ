using Microsoft.AspNetCore.Mvc;
using PortfolioProject_AkademiQ.Data;
using PortfolioProject_AkademiQ.Entities;

namespace PortfolioProject_AkademiQ.Controllers
{
    public class WorkController : Controller
    {
        private readonly AppDbContext _context;

        public WorkController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var values = _context.Works.ToList();
            return View(values);
        }

        public IActionResult DeleteWork(int id)
        {
            var values = _context.Works.Find(id);
            _context.Works.Remove(values);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult CreateWork() => View();

        [HttpPost]
        public IActionResult CreateWork(Work work)
        {
            _context.Works.Add(work);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult UpdateWork(int id)
        {
            var values = _context.Works.Find(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateWork(Work work)
        {
            var values = _context.Works.Find(work.WorkId);
            values.Title = work.Title;
            values.SubTitle = work.SubTitle;
            values.ImageUrl = work.ImageUrl;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
