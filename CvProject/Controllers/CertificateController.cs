using CvProject.Models.Entities;
using CvProject.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CvProject.Controllers
{
    public class CertificateController : Controller
    {
        CertificateRepository _certificateRepository=new CertificateRepository();
        public IActionResult Index()
        {
            var value = _certificateRepository.List();
            return View(value);
        }
        [HttpGet]
        public IActionResult Get(int id)
        {
            var value=_certificateRepository.Find(x => x.Id == id);
            return View();
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        public IActionResult Delete(int id)
        {
            var value = _certificateRepository.Find(x => x.Id == id);
            _certificateRepository.Delete(value);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Add(Certificate certificate)
        {
            _certificateRepository.Add(certificate);

            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            var value = _certificateRepository.Find(x => x.Id == id);
            ViewBag.d = id;
            return View();
        }

        [HttpPost]
        public IActionResult Update(Certificate certificate)
        {
            var value = _certificateRepository.Find(x => x.Id == certificate.Id);
            value.Description = certificate.Description;
            value.Date = certificate.Date;
            _certificateRepository.Update(value);
            return RedirectToAction("Index");

        }
    }
}
