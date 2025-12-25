
using Microsoft.AspNetCore.Mvc;

namespace PortfolioProject_AkademiQ.ViewComponents
{
    public class _DefaultNavBarComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
