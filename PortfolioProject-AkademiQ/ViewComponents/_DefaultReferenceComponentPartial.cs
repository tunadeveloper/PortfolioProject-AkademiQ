using Microsoft.AspNetCore.Mvc;
using PortfolioProject_AkademiQ.Data;

namespace PortfolioProject_AkademiQ.ViewComponents
{
    public class _DefaultReferenceComponentPartial : ViewComponent
    {
        private readonly AppDbContext _context;

        public _DefaultReferenceComponentPartial(AppDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var values = _context.References.ToList();
            return View(values);
        }
    }
}
