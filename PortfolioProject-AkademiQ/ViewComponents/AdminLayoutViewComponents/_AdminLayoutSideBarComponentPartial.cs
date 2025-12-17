
using Microsoft.AspNetCore.Mvc;

namespace PortfolioProject_AkademiQ.ViewComponents.AdminLayoutViewComponents
{
    public class _AdminLayoutSideBarComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
