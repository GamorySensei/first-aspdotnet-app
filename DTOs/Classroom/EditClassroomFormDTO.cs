using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FirstAspDotnetApp.DTOs.Classroom
{
    public class EditClassroomFormDTO
    {
        public int Id { get; set; }

        [DisplayName("Nom de la classe")]
        [Required(ErrorMessage = "Le nom est obligaoire")]
        public string Name { get; set; }
    }
}
