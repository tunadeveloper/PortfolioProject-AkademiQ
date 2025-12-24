
using Microsoft.AspNetCore.Mvc;
using PortfolioProject_AkademiQ.Data;

namespace PortfolioProject_AkademiQ.ViewComponents.AdminLayoutViewComponents
{
    public class _AdminLayoutSideBarComponentPartial:ViewComponent
    {
        private readonly AppDbContext _context;

        public _AdminLayoutSideBarComponentPartial(AppDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.messagesCountByIsReadFalse = _context.Messages.Count(m => m.IsRead == false);
            return View();
        }
    }
}
