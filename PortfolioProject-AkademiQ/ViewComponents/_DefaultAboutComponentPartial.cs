using Microsoft.AspNetCore.Mvc;

namespace PortfolioProject_AkademiQ.ViewComponents
{
    public class _DefaultAboutComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
