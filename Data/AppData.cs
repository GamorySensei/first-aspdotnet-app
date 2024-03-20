using FirstAspDotnetApp.Models;

namespace FirstAspDotnetApp.Data
{
    public class AppData
    {
        public List<Classroom> Classrooms { get; set; }
        public AppData() {
            Classrooms = new List<Classroom>()
            {
                new()
                {
                    Id = 1,
                    Name = "CDA - C#",
                    Students =
                    [
                        new()
                        {
                            Firstname = "Imane",
                            Lastname = "Cherraj"
                        },
                        new()
                        {
                            Firstname = "Arnaud",
                            Lastname = "Muller"
                        },
                        new()
                        {
                            Firstname = "Alexandre",
                            Lastname = "Dach"
                        },
                        new()
                        {
                            Firstname = "Axel",
                            Lastname = "Martin"
                        },
                        new()
                        {
                            Firstname = "Cyril",
                            Lastname = "Cherrier"
                        },
                        new()
                        {
                            Firstname = "Jessica",
                            Lastname = "Gualtieri"
                        },
                        new()
                        {
                            Firstname = "Mathias",
                            Lastname = "Dumas"
                        },
                        new()
                        {
                            Firstname = "Isabelle",
                            Lastname = "Apoux"
                        },
                        new()
                        {
                            Firstname = "Florent",
                            Lastname = "Bernar"
                        },
                        new()
                        {
                            Firstname = "Alexandre",
                            Lastname = "Cerf"
                        },
                        new()
                        {
                            Firstname = "Clément",
                            Lastname = "Parpaiola"
                        },
                        new()
                        {
                            Firstname = "Fabien",
                            Lastname = "Hasselmann"
                        },
                        new()
                        {
                            Firstname = "Nathan",
                            Lastname = "Randoulet"
                        },
                        new()
                        {
                            Firstname = "Louis",
                            Lastname = "Kuster"
                        },
                        new ()
                        {
                            Firstname = "Thomas",
                            Lastname = "Thouvenin"
                        },
                        new()
                        {
                            Firstname = "Nadejda",
                            Lastname = "Teriokhina"
                        },
                        new()
                        {
                            Firstname = "Necati",
                            Lastname = "Han"
                        }
                    ]
                },
            };
        }
    }
}
