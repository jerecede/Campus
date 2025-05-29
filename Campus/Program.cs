using Campus.Model;
using Microsoft.EntityFrameworkCore;

namespace Campus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            //// create tests for my classes, please 
            var course1 = new Course(1, "Algebra", 30, null);
            var course2 = new Course(2, "Biology", 30, null);

            var teacher1 = new Teacher(1, "Alice", "Math", null);
            var teacher2 = new Teacher(2, "Bob", "Science", null);

            var student1 = new Student(1, "Charlie", 10, null);
            var student2 = new Student(2, "Diana", 11, null);

            var school = new School(1, "Greenwood High", new List<Teacher> { teacher1, teacher2 }, new List<Student> { student1, student2 });

            //var courses = school.GetCourses();
            //var students = school.GetStudents();
            //var teachers = school.GetTeachers();
            //var aliceSCourses = school.GetCoursesByTeacherId(1);
            //var dianaSCourses = school.GetCoursesByStudentId(2);

            //foreach (var item in dianaSCourses)
            //{
            //    Console.WriteLine($"{item.Name}");
            //}

            var context = new CampusContext();


            //context.Schools.Add(school);

            //context.SaveChanges();

            var schools = context.Schools
                .Include(school => school.Teachers)
                .Include(school => school.Students)
                .ToList();

            foreach (var item in schools)
            {
                Console.WriteLine($"school: {item.Name}");
                foreach (var teacher in school.Teachers)
                {
                    Console.WriteLine($"teacher: {teacher.Name}");
                }
                foreach (var student in school.Students)
                {
                    Console.WriteLine($"student: {student.Name}");
                }
            }
        }
    }
}
