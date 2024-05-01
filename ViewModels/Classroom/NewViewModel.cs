using FirstAspDotnetApp.DTOs.Classroom;

namespace FirstAspDotnetApp.ViewModels.Classroom
{
    public class NewViewModel
    {
        public CreateClassroomFormDTO NewClassroomForm { get; set; }

        public NewViewModel()
        {
            NewClassroomForm = new CreateClassroomFormDTO();
        }

    }
}
