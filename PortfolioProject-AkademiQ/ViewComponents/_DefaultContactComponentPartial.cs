using Microsoft.AspNetCore.Mvc;
using PortfolioProject_AkademiQ.Data;

namespace PortfolioProject_AkademiQ.ViewComponents
{
    public class _DefaultContactComponentPartial:ViewComponent
    {
        private readonly AppDbContext _context;

        public _DefaultContactComponentPartial(AppDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var contact = _context.Contacts.FirstOrDefault();
            return View(contact);
        }
    }
}
