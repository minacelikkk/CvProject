using CvProject.Models.Entities;
using CvProject.Repositories;
using Microsoft.AspNetCore.Mvc;


namespace CvProject.Controllers
{
    public class AboutController : Controller
    {
        AboutRepository _aboutRepository=new AboutRepository();
        [HttpGet]
        public IActionResult Index()
        {
            var value=_aboutRepository.List();
            return View(value);
        }
        [HttpPost]
        public IActionResult Index(About about)

        {
            var value = _aboutRepository.Find(x => x.Id == 1);
            value.FirstName=about.FirstName;
            value.LastName=about.LastName;
            value.Email=about.Email;
            value.Telephone=about.Telephone;
            value.Description=about.Description;
            value.Address=about.Address;
            value.Image=about.Image;
            _aboutRepository.Update(value);
            return RedirectToAction("Index");
        }
    }
}
