using CvProject.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CvProject.ViewComponents.Skill
{
    public class SkillList:ViewComponent
    {
        CvDbContext _dbContext = new CvDbContext();
        public IViewComponentResult Invoke()
        {
            var value = _dbContext.Skills.ToList();
            return View(value);
        }
    }
}
