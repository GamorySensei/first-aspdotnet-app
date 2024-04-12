using FirstAspDotnetApp.Data;
using FirstAspDotnetApp.DTOs.Classroom;
using FirstAspDotnetApp.Exceptions;
using FirstAspDotnetApp.Models;
using FirstAspDotnetApp.ViewModels.Classroom;
using FirstAspDotnetApp.ViewModels.Error;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace FirstAspDotnetApp.Controllers
{
    public class ClassroomController(FirstAspDotNetAppDbContext dbContext) : Controller
    {

        public IActionResult Index()
        {
            var model = new IndexViewModel
            {
                Classrooms = dbContext.Classrooms.ToList(),
            };
            return View(model);
        }

        public IActionResult Students(int Id)
        {
            try
            {

                var classroom = dbContext.Classrooms.Include(c => c.Students).FirstOrDefault(c => c.Id == Id) ?? throw new UserFriendlyException("Classe inexistante", ExceptionTypeEnum.Warning);
                
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

        public IActionResult New([Bind]NewViewModel data)
        {
            var model = new NewViewModel();

            if(ModelState.IsValid)
            {
                var formData = data.NewClassroomForm;
                var newClassroom = new Classroom
                {
                    Name = formData.Name
                };

                dbContext.Add(newClassroom);
                dbContext.SaveChanges();
            }

            return View(model);
        }
    }
}
