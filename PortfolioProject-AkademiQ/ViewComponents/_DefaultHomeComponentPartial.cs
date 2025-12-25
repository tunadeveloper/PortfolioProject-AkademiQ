using Microsoft.AspNetCore.Mvc;

namespace PortfolioProject_AkademiQ.ViewComponents
{
    public class _DefaultHomeComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
