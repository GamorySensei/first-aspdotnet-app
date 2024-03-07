namespace FirstAspDotnetApp.Models
{
    public class Classroom
    {
        public string? Name { get; set; }

        public List<Student> Students { get; set; }

        public Classroom() 
        { 
            Students = new List<Student>();
        }
    }
}
