using CvProject.Models.Entities;
using CvProject.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CvProject.Controllers
{
    public class SocialMediaController : Controller
    {
        SocialMediaRepository _socialMediaRepository = new SocialMediaRepository();
        public IActionResult Index()
        {
            var value = _socialMediaRepository.List();
            return View(value);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(SocialMedia socialMedia)
        {
            _socialMediaRepository.Add(socialMedia);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var value = _socialMediaRepository.Find(x => x.Id == id);
            _socialMediaRepository.Delete(value);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Update(/*int id*/)
        {
            //var value = _socialMediaRepository.Get(id);

            //List<SelectListItem> values = (from s in _socialMediaRepository.List()
            //                                       select new SelectListItem
            //                                       {
            //                                           Text = s.Icon,
            //                                           Value = s.Icon.ToString()
            //                                       }).ToList();
            //ViewBag.cv = values;
            //return View(value);
            return View();
        }

        [HttpPost]
        public IActionResult Update(SocialMedia socialMedia)
        {
            var value = _socialMediaRepository.Find(x => x.Id == socialMedia.Id);
            value.SocialMediaName = socialMedia.SocialMediaName;
            value.Link = socialMedia.Link;
            value.Icon = socialMedia.Icon;
            _socialMediaRepository.Update(value);
            return RedirectToAction("Index");

        }
    }
}
