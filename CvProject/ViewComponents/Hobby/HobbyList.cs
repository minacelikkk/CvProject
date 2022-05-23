using CvProject.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CvProject.ViewComponents.Hobby
{
    public class HobbyList:ViewComponent
    {
        CvDbContext _dbContext = new CvDbContext();
        public IViewComponentResult Invoke()
        {
            var value = _dbContext.Hobbies.ToList();
            return View(value);
        }
    }
}
