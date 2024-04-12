using System.ComponentModel.DataAnnotations;

namespace FirstAspDotnetApp.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string Firstname { get; set; }

        public string Lastname { get; set; }
    }
}
