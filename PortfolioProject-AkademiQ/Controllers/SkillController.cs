using Microsoft.AspNetCore.Mvc;
using PortfolioProject_AkademiQ.Data;
using PortfolioProject_AkademiQ.Entities;

namespace PortfolioProject_AkademiQ.Controllers
{
    public class SkillController : Controller
    {
        private readonly AppDbContext _context;

        public SkillController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var values = _context.Skills.ToList();
            return View(values);
        }
        public IActionResult CreateSkill() => View();

        [HttpPost]
        public IActionResult CreateSkill(Skill skill)
        {
            _context.Skills.Add(skill);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }
        public IActionResult DeleteSkill(int id)
        {
            var values = _context.Skills.Find(id);
            _context.Skills.Remove(values);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult UpdateSkill(int id)
        {
            var values = _context.Skills.Find(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateSkill(Skill skill)
        {
            var values = _context.Skills.Find(skill.SkillId);
            values.SkillTitle = skill.SkillTitle;
            values.SkillValue = skill.SkillValue;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
