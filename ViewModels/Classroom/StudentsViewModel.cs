using FirstAspDotnetApp.Models;

namespace FirstAspDotnetApp.ViewModels.Classroom
{
    public class StudentsViewModel
    {
        public string? ClassroomName { get; set; }
        public List<Student> Students { get; set; }

        public StudentsViewModel() { 
        
            Students = [];
        }
    }
}
