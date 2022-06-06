using CvProject.Models.Entities;
using CvProject.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CvProject.Controllers
{
    public class SkillController : Controller
    {
       SkillRepository _skillRepository=new SkillRepository();
        public IActionResult Index()
        {
            var value = _skillRepository.List();
            return View(value);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Skill skill)
        {
            _skillRepository.Add(skill);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var value = _skillRepository.Find(x => x.Id == id);
            _skillRepository.Delete(value);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            var updatedEntity=_skillRepository.Get(id);
            return View(updatedEntity);
        }

        [HttpPost]
        public IActionResult Update(Skill skill)
        {
            var value = _skillRepository.Find(x => x.Id == skill.Id);
            value.Skill1 = skill.Skill1;
            value.Oran = skill.Oran;
            _skillRepository.Update(value);
            return RedirectToAction("Index");

        }
    }
}
