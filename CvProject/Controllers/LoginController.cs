using CvProject.Models.Entities;
using CvProject.Repositories;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace CvProject.Controllers
{
    public class LoginController : Controller
    {
        AdminRepository _adminRepository = new AdminRepository();

        [Authorize]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(Admin admin)
        {
            var value=_adminRepository.List().FirstOrDefault(x=>x.UserName==admin.UserName &&x.Password==admin.Password);
            if (value != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,admin.UserName)
                };
                var userIdentity=new ClaimsIdentity(claims,"Login");
                ClaimsPrincipal claimsPrincipal=new ClaimsPrincipal(userIdentity);
                await HttpContext.SignInAsync(claimsPrincipal);
                return RedirectToAction("Index","Exper");
            }
            return RedirectToAction("Index", "Login");
        }
    }
}