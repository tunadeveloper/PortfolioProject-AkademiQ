using Microsoft.AspNetCore.Mvc;
using PortfolioProject_AkademiQ.Data;

namespace PortfolioProject_AkademiQ.ViewComponents
{
    public class _DefaultPortfolioComponentPartial:ViewComponent
    {
        private readonly AppDbContext _context;

        public _DefaultPortfolioComponentPartial(AppDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var values = _context.Works.OrderByDescending(x=>x.WorkId).ToList();
            return View(values);
        }
        }
}
