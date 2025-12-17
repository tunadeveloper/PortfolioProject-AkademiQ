using Microsoft.AspNetCore.Mvc;
using PortfolioProject_AkademiQ.Data;

namespace PortfolioProject_AkademiQ.ViewComponents
{
    public class _DefaultAboutComponentPartial:ViewComponent
    {
        private readonly AppDbContext _context;

        public _DefaultAboutComponentPartial(AppDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var values = _context.Abouts.FirstOrDefault();
            return View(values);
        }
    }
}
