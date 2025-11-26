
using Microsoft.AspNetCore.Mvc;

namespace PortfolioProject_AkademiQ.ViewComponents
{
    public class _DefaultFeatureComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
        }
}
