using Microsoft.AspNetCore.Mvc;
using CvProject.Models.Entities;

namespace CvProject.ViewComponents.Experience
{
    public class ExperienceList:ViewComponent
    {
        CvDbContext _dbContext=new CvDbContext();
        public IViewComponentResult Invoke()
        {
            var value = _dbContext.Experiences.ToList();
            return View(value);
        }
    }
}
