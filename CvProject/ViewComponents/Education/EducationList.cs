using CvProject.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CvProject.ViewComponents.Education
{
    public class EducationList:ViewComponent
    {
        CvDbContext _dbContext = new CvDbContext();
        public IViewComponentResult Invoke()
        {
            var value = _dbContext.Educations.ToList();
            return View(value);
        }
    }
}
