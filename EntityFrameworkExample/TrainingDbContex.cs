using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkExample
{
    public class TrainingDbContext : DbContext
    {
        private readonly string _connectionString= "Server=DESKTOP-8DI1SVB\\SQLEXPRESS;Database=CSharpB18;User Id=csharpb18;Password=123456; Trust Server Certificate=True";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_connectionString);
            }
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentEnrollment>().HasKey((x) => new {x.CourseId,x.StudentId});
            modelBuilder.Entity<Topics>().ToTable("Topics");
            modelBuilder.Entity<StudentEnrollment>().ToTable("StudentEnrollments");
            base.OnModelCreating(modelBuilder);

        }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
