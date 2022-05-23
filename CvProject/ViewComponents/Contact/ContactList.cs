using CvProject.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CvProject.ViewComponents.Contact
{
    public class ContactList:ViewComponent
    {

        CvDbContext _dbContext = new CvDbContext();
        public IViewComponentResult Invoke()
        {
            var value = _dbContext.Contacts.ToList();
            return View(value);
        }
     

    }
}
