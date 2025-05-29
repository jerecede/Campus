namespace Campus.Model
{
    internal class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Student> Students { get; set; } 
        public int StudentLimit { get; set; }
        public int TeacherId { get; set; }
        public Teacher? Teacher { get; set; }

        public Course()
        {
        }

        public Course(int id, string name, int studentLimit, List<Student>? students)
        {
            Id = id;
            Name = name;
            Students = students ?? new List<Student>();
            StudentLimit = studentLimit;
        }

        public Course(string name, int studentLimit, List<Student>? students)
        {
            Name = name;
            Students = students ?? new List<Student>();
            StudentLimit = studentLimit;
        }

    }
}