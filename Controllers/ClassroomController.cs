using FirstAspDotnetApp.Data;
using FirstAspDotnetApp.ViewModels.Classroom;
using Microsoft.AspNetCore.Mvc;

namespace FirstAspDotnetApp.Controllers
{
    public class ClassroomController(AppData appData) : Controller
    {

        public IActionResult Index()
        {
            var model = new IndexViewModel
            {
                Classrooms = appData.Classrooms,
            };
            return View(model);
        }

        public IActionResult Students(int Id)
        {
            var classroom = appData.Classrooms.Find(x => x.Id ==  Id);
            var model = new StudentsViewModel
            {
                ClassroomName = classroom.Name,
                Students = classroom.Students,
            };
            return View(model);
        }
    }
}
