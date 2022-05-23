using CvProject.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CvProject.ViewComponents.Certificate
{
    public class CertificateList:ViewComponent
    {
        CvDbContext _dbContext = new CvDbContext();
        public IViewComponentResult Invoke()
        {
            var value = _dbContext.Certificates.ToList();
            return View(value);
        }
    }
}
