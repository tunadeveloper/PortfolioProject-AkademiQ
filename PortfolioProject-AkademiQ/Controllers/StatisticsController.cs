using Microsoft.AspNetCore.Mvc;
using PortfolioProject_AkademiQ.Data;

namespace PortfolioProject_AkademiQ.Controllers
{
    public class StatisticsController : Controller
    {
        private readonly AppDbContext _context;

        public StatisticsController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ViewBag.messagesCount = _context.Messages.Count();
            ViewBag.messagesCountByIsReadTrue = _context.Messages.Count(m => m.IsRead == true);
            ViewBag.messagesCountByIsReadFalse = _context.Messages.Count(m => m.IsRead == false);

            ViewBag.skillCount = _context.Skills.Count();
            ViewBag.skillAvgValue = _context.Skills.Any() ? _context.Skills.Average(s => s.SkillValue) : 0;

            var latestMessages = _context.Messages.OrderByDescending(x => x.MessageId).Take(5).ToList();
            return View(latestMessages);
        }
    }
}
