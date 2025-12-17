using Microsoft.AspNetCore.Mvc;
using PortfolioProject_AkademiQ.Data;

namespace PortfolioProject_AkademiQ.ViewComponents
{
    public class _DefaultExperienceComponentPartial:ViewComponent
    {
        private readonly AppDbContext _context;

        public _DefaultExperienceComponentPartial(AppDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {

            var values = _context.Experiences.ToList();
            return View(values);
        }
        }
}
