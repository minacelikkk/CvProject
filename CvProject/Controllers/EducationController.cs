using CvProject.Models.Entities;
using CvProject.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CvProject.Controllers
{
    public class EducationController : Controller
    {
        EducationRepository _educationRepository=new EducationRepository();
        [Authorize]
        public IActionResult Index()
        {
            var value=_educationRepository.List();
            return View(value);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Education education)
        {
            _educationRepository.Add(education);

            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var value = _educationRepository.Find(x => x.Id == id);
            _educationRepository.Delete(value);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Update()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Update(Education education)
        {
            var value = _educationRepository.Find(x => x.Id == education.Id);
            value.Title = education.Title;
            value.Subtitle = education.Subtitle;
            value.Subtitle2 = education.Subtitle2;
            value.Gpa = education.Gpa;
            value.Date = education.Date;
            _educationRepository.Update(value);
            return RedirectToAction("Index");

        }
    }
}
