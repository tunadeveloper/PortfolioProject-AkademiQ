using Microsoft.AspNetCore.Mvc;
using PortfolioProject_AkademiQ.Data;
using PortfolioProject_AkademiQ.Entities;

namespace PortfolioProject_AkademiQ.ViewComponents
{
    public class _DefaultSendMessageComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var model = new Message();
            return View(model);
        }
    }
}
