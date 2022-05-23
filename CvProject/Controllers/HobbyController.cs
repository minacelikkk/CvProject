using CvProject.Models.Entities;
using CvProject.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CvProject.Controllers
{
    public class HobbyController : Controller
    {
        HobbyRepository _hobbyRepository=new HobbyRepository();
        [HttpGet]
        public IActionResult Index()
        {
            var value=_hobbyRepository.List();
            return View(value);
        }
        [HttpPost]
        public ActionResult Index(Hobby hobby)
        {
            var value = _hobbyRepository.Find(x => x.Id ==hobby.Id );
            value.Description=hobby.Description;
            value.Description2 = hobby.Description2;
            _hobbyRepository.Update(hobby);
            return RedirectToAction("Index");
        }

    }
}
