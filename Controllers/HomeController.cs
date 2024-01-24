using Contact_us_form.Context;
using Contact_us_form.Models;
using Microsoft.AspNetCore.Mvc;

namespace Contact_us_form.Controllers
{
    public class HomeController : Controller
    {
        private ContactUsContext _db;
        public HomeController(ContactUsContext context)
        {
            _db = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SendMessage(Message message)
        {
            _db.messages.Add(message);
            _db.SaveChanges();
            return Redirect("/home/Messages");
        }

        public IActionResult Messages()
        {
            return View(_db.messages.ToList());
        }

    }
}
