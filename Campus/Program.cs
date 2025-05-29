using Campus.Model;

namespace Campus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // create tests for my classes, please 
            var course1 = new Course(1, "Algebra", 30, null);
            var course2 = new Course(2, "Biology", 30, null);

            var teacher1 = new Teacher(1, "Alice", "Math", new List<Course>(){ course1});
            var teacher2 = new Teacher(2, "Bob", "Science", new List<Course>() { course2 });

            var student1 = new Student(1, "Charlie", 10, new List<Course>() { course1 });
            var student2 = new Student(2, "Diana", 11, new List<Course>() { course1, course2 });
            
            var school = new School(1, "Greenwood High", new List<Model.Teacher> { teacher1, teacher2 }, new List<Model.Student> { student1, student2 });

            var courses = school.GetCourses();
            var students = school.GetStudents();
            var teachers = school.GetTeachers();
            var aliceSCourses = school.GetCoursesByTeacherId(1);
            var dianaSCourses = school.GetCoursesByStudentId(2);

            foreach (var item in dianaSCourses)
            {
                Console.WriteLine($"{item.Name}");
            }
        }
    }
}
