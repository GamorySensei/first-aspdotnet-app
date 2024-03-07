using FirstAspDotnetApp.ViewModels.Classroom;
using Microsoft.AspNetCore.Mvc;

namespace FirstAspDotnetApp.Controllers
{
    public class ClassroomController : Controller
    {
        public IActionResult Index()
        {
            var model = new IndexViewModel();
            return View(model);
        }

        public IActionResult Students(int Id)
        {
            ViewData["id"] = Id;
            return View();
        }
    }
}
