
namespace FirstAspDotnetApp.ViewModels.Classroom
{
    public class IndexViewModel
    {
        public List<Models.Classroom> Classrooms { get; set; }

        public IndexViewModel()
        {
            Classrooms = new List<Models.Classroom>()
            {
                new Models.Classroom()
                {
                    Name = "CDA - C#",
                    Students = new List<Models.Student>()
                    {
                        new Models.Student()
                        {
                            Firstname = "Imane",
                            Lastname = "Cherraj"
                        },
                        new Models.Student()
                        {
                            Firstname = "Arnaud",
                            Lastname = "Muller"
                        },
                        new Models.Student()
                        {
                            Firstname = "Alexandre",
                            Lastname = "Dach"
                        },
                        new Models.Student()
                        {
                            Firstname = "Axel",
                            Lastname = "Martin"
                        },
                        new Models.Student()
                        {
                            Firstname = "Cyril",
                            Lastname = "Cherrier"
                        },
                        new Models.Student()
                        {
                            Firstname = "Jessica",
                            Lastname = "Gualtieri"
                        },
                        new Models.Student()
                        {
                            Firstname = "Mathias",
                            Lastname = "Dumas"
                        },
                        new Models.Student()
                        {
                            Firstname = "Isabelle",
                            Lastname = "Apoux"
                        },
                        new Models.Student()
                        {
                            Firstname = "Florent",
                            Lastname = "Bernar"
                        },
                        new Models.Student()
                        {
                            Firstname = "Alexandre",
                            Lastname = "Cerf"
                        },
                        new Models.Student()
                        {
                            Firstname = "Clément",
                            Lastname = "Parpaiola"
                        },
                        new Models.Student()
                        {
                            Firstname = "Fabien",
                            Lastname = "Hasselmann"
                        },
                        new Models.Student()
                        {
                            Firstname = "Nathan",
                            Lastname = "Randoulet"
                        },
                        new Models.Student()
                        {
                            Firstname = "Louis",
                            Lastname = "Kuster"
                        },
                        new Models.Student()
                        {
                            Firstname = "Thomas",
                            Lastname = "Thouvenin"
                        },
                        new Models.Student()
                        {
                            Firstname = "Nadejda",
                            Lastname = "Teriokhina"
                        },
                        new Models.Student()
                        {
                            Firstname = "Necati",
                            Lastname = "Han"
                        }
                    }
                },
            };

        }
    }
}
