using Microsoft.AspNetCore.Mvc;
using PortfolioProject_AkademiQ.Data;

namespace PortfolioProject_AkademiQ.ViewComponents
{
    public class _DefaultHobbyComponentPartial:ViewComponent
    {
        private readonly AppDbContext _context;

        public _DefaultHobbyComponentPartial(AppDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var values = _context.Hobbies.ToList();
            return View(values);
        }
    }
}
