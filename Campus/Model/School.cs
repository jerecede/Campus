using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campus.Model
{
    internal class School
    {
        public int Id { get; set; }    
        public string Name { get; set; }
        public List<Teacher> Teachers { get; set; }
        public List<Student> Students { get; set; }

        public School()
        {
        }

        public School(int id, string name, List<Teacher>? teachers, List<Student>? students)
        {
            Id = id;
            Name = name;
            Teachers = teachers ?? new List<Teacher>();
            Students = students ?? new List<Student>();
        }

        public School(string name, List<Teacher>? teachers, List<Student>? students)
        {
            Name = name;
            Teachers = teachers ?? new List<Teacher>();
            Students = students ?? new List<Student>();
        }

        internal List<Course> GetCourses()
        {
            var courses = new List<Course>();
            foreach (var teacher in Teachers)
            {
                foreach (var course in teacher.Courses)
                {
                   courses.Add(course);
                }
            }
            return courses;
        }

        internal List<Student> GetStudents()
        {
            return Students;
        }

        internal List<Teacher> GetTeachers()
        {
            return Teachers;
        }

        internal List<Course> GetCoursesByTeacherId(int id)
        {
            foreach (var teacher in Teachers)
            {
                if (teacher.Id == id)
                {
                    return teacher.Courses;
                }
            }
            return new List<Course>();
        }

        internal List<Course> GetCoursesByStudentId(int id)
        {
            foreach (var student in Students)
            {
                if (student.Id == id)
                {
                    return student.Courses;
                }
            }
            return new List<Course>();
        }
    }
}
