using KursKayit.Models;
using Microsoft.AspNetCore.Mvc;

namespace KursKayit.Controllers
{
    public class CourseController:Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Apply()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Apply([FromForm] Candidate model)
        {
            Repository.Add(model);
            return View("FeedBack",model);
        }
        
    }
}