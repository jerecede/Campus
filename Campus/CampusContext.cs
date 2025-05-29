using Campus.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campus
{
    internal class CampusContext: DbContext
    {
        public DbSet<School> Schools { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=campus;Username=postgres;Password=superpippo;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Teacher>()
                .HasOne(teacher => teacher.School)
                .WithMany(school => school.Teachers)
                .HasForeignKey(teacher => teacher.SchoolId);

            modelBuilder.Entity<Student>()
                .HasOne(student => student.School)
                .WithMany(school => school.Students)
                .HasForeignKey(student => student.SchoolId);

            modelBuilder.Entity<Course>()
                .HasOne(course => course.Teacher)
                .WithMany(teacher => teacher.Courses)
                .HasForeignKey(course => course.TeacherId);

            modelBuilder.Entity<Course>()
                .HasMany(course => course.Students)
                .WithMany(student => student.Courses)
                .UsingEntity(tabellaDiPassaggio => tabellaDiPassaggio.ToTable("CourseStudents"));
        }

    }

}
