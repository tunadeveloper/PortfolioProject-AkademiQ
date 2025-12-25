using Microsoft.AspNetCore.Mvc;

namespace PortfolioProject_AkademiQ.ViewComponents
{
    public class _DefaultFooterComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
