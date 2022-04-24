using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Data.Models;

namespace University.Data
{
    public class UniversityContext : DbContext
    {
        public UniversityContext()
        {

        }

        public UniversityContext(DbContextOptions options) : base(options)
        {

        }

        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Resource> Resources { get; set; }
        public virtual DbSet<Homework> HomeworkSubmissions { get; set; }
        public virtual DbSet<StudentCourse> StudentCourses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(connectionString: @"Server=.;Database=University;Integrated Security=True;");
            }

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentCourse>(entity =>
            {
                entity.HasKey(sc => new { sc.CourseId, sc.StudentId });
            });
        }
    }
}
