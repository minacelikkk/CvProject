using CvProject.Models.Entities;
using CvProject.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CvProject.Controllers
{
    public class ProjectController : Controller
    {
        ProjectRepository _projectRepository = new ProjectRepository();
        public IActionResult Index()
        {
            var values=_projectRepository.List();
            return View(values);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Project project)
        {
            _projectRepository.Add(project);

            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            var value = _projectRepository.Find(x => x.Id == id);
            return View();
        }

        [HttpPost]
        public IActionResult Update(Project project)
        {
            var value = _projectRepository.Find(x => x.Id == project.Id);
            value.ProjectName = project.ProjectName;
            value.ProjectUrl = project.ProjectUrl;
            _projectRepository.Update(value);
            return RedirectToAction("Index");

        }
    }
}
