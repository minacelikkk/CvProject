using CvProject.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CvProject.Controllers
{
    public class ContactController : Controller
    {
        ContactRepository _contactRepository = new ContactRepository();
        public IActionResult Index()
        {
            var value=_contactRepository.List();
            return View(value);
        }
    }
}
