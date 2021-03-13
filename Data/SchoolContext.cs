using ContosoUniversity.Models;
using Microsoft.EntityFrameworkCore;

namespace ContosoUniversity.Data
{
    public class SchoolContext : DbContext
    {
        //tinfo200:[2021-03-11-edmo3000-dykstra2] - do nohting ctor
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {
        }

        //tinfo200:[2021-03-11-edmo3000-dykstra2] - DbSet props, which represent a collection of all entites which can be used for CRUD
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Student> Students { get; set; }

        //tinfo200:[2021-03-11-edmo3000-dykstra2] - override default behavior of pluralized names for signular table names
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().ToTable("Course");
            modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
            modelBuilder.Entity<Student>().ToTable("Student");
        }
    }
}
