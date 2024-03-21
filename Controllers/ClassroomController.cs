using FirstAspDotnetApp.Data;
using FirstAspDotnetApp.Exceptions;
using FirstAspDotnetApp.Models;
using FirstAspDotnetApp.ViewModels.Classroom;
using FirstAspDotnetApp.ViewModels.Error;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

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
            try
            {

                var classroom = appData.Classrooms.Find(x => x.Id == Id) ?? throw new UserFriendlyException("Classe inexistante", ExceptionTypeEnum.Warning);
                
                var model = new StudentsViewModel
                {
                    ClassroomName = classroom.Name,
                    Students = classroom.Students,
                };
                return View(model);

            }
            catch(UserFriendlyException ufe)
            {
                return View("Views/Shared/UserFriendlyError.cshtml", new UserFriendlyErrorViewModel(ufe));
            }
            catch(Exception ex)
            {
                return View("Views/Shared/Error.cshtml", new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
            }

        }
    }
}
