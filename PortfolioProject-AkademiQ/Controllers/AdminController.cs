using Microsoft.AspNetCore.Mvc;

namespace PortfolioProject_AkademiQ.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
