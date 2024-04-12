using FirstAspDotnetApp.Models;
using Microsoft.EntityFrameworkCore;

namespace FirstAspDotnetApp.Data
{
    public class FirstAspDotNetAppDbContext : DbContext
    {

        public DbSet<Classroom> Classrooms { get; set; }

        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            string connectionString = "server=localhost;user=root;database=firstaspnetappdb";
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }


    }
}
