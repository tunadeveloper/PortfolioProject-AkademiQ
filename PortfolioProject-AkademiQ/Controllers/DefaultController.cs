using Microsoft.AspNetCore.Mvc;

namespace PortfolioProject_AkademiQ.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
