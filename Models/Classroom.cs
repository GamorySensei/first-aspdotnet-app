using System.ComponentModel.DataAnnotations;

namespace FirstAspDotnetApp.Models
{
    public class Classroom
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }

        public List<Student> Students { get; set; }

        public Classroom() 
        { 
            Students = new List<Student>();
        }
    }
}
