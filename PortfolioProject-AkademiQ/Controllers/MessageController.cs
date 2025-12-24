using Microsoft.AspNetCore.Mvc;
using PortfolioProject_AkademiQ.Data;
using X.PagedList;
using X.PagedList.Extensions;

namespace PortfolioProject_AkademiQ.Controllers
{
    public class MessageController : Controller
    {
        private readonly AppDbContext _context;

        public MessageController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(int page = 1)
        {
            int pageSize = 6;
            var values = _context.Messages
                .OrderByDescending(x => x.SendDate)
                .ToPagedList(page, pageSize);

            return View(values);
        }

        [HttpGet]
        public IActionResult GetMessageDetails(int id)
        {
            var value = _context.Messages.Find(id);

            if (value != null)
            {
                if (value.IsRead == false)
                {
                    value.IsRead = true;
                    _context.SaveChanges();
                }
                return Json(new
                {
                    messageId = value.MessageId,
                    senderName = value.SenderName,
                    senderEmail = value.SenderEmail,
                    subject = value.Subject,
                    messageText = value.MessageText,
                    sendDate = value.SendDate.HasValue ? value.SendDate.Value.ToString("dd MMM yyyy") : "",
                    sendTime = value.SendDate.HasValue ? value.SendDate.Value.ToString("HH:mm") : ""
                });
            }

            return NotFound();
        }

        public IActionResult DeleteMessage(int id)
        {
            var values = _context.Messages.Find(id);
            _context.Messages.Remove(values);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}