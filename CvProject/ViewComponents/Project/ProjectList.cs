using CvProject.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CvProject.ViewComponents.Project
{
    public class ProjectList:ViewComponent
    {
        CvDbContext _dbContext = new CvDbContext();
        public IViewComponentResult Invoke()
        {
            var value = _dbContext.Projects.ToList();
            return View(value);
        }
    }
}
