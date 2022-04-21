using BigbrainProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace BigbrainProject.Controllers
{
    public class KidController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(KidModel model)
        {
            return RedirectToAction("Index");
        }
    }
}
