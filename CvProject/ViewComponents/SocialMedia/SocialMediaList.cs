using CvProject.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CvProject.ViewComponents.SocialMedia
{
    public class SocialMediaList:ViewComponent
    {

        CvDbContext _dbContext = new CvDbContext();
        public IViewComponentResult Invoke()
        {
            var value = _dbContext.SocialMedias.ToList();
            return View(value);
        }
    }
}
