using CvProject.Models.Entities;
using CvProject.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CvProject.Controllers
{
    public class ExperienceController : Controller
    {
        ExperienceRepository _experienceRepository = new ExperienceRepository();
        public IActionResult Index()
        {
            var value = _experienceRepository.List();
            return View(value);
        }
        public IActionResult Delete(int id)
        {
            var value = _experienceRepository.Find(x => x.Id == id);
            _experienceRepository.Delete(value);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Experience experience)
        {
            _experienceRepository.Add(experience);

            return RedirectToAction("Index");
        }
        public IActionResult Get(int id)
        {
            var value = _experienceRepository.Find(x => x.Id == id);
            return View(value);
        }
        [HttpGet]
        public IActionResult Update()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Update(Experience experience)
        {
            var value = _experienceRepository.Find(x => x.Id == experience.Id);
            value.Title = experience.Title;
            value.Subtitle = experience.Subtitle;
            value.Description = experience.Description;
            value.Date = experience.Date;
            _experienceRepository.Update(value);
            return RedirectToAction("Index");

        }

    }
}




