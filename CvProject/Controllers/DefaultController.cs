using Microsoft.AspNetCore.Mvc;
using CvProject.Models.Entities;
using System.Linq;
namespace CvProject.Controllers
{
    public class DefaultController : Controller
    {
        CvDbContext _dbContext=new CvDbContext();
        public IActionResult Index()
        {
            var value = _dbContext.Abouts.ToList();
           
            return View(value);
        }
    }
}
