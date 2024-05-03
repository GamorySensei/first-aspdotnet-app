using FirstAspDotnetApp.DTOs.Classroom;

namespace FirstAspDotnetApp.ViewModels.Classroom
{
    public class EditClassroomViewModel
    {
        public EditClassroomFormDTO EditClassroomForm { get; set; }

        public EditClassroomViewModel()
        {
            EditClassroomForm = new EditClassroomFormDTO();
        }
    }
}
