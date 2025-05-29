namespace Campus.Model
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Grade { get; set; }
        public List<Course> Courses { get; set; }
        public int SchoolId { get; set; }
        public School? School { get; set; }
        public Student()
        {
        }
        public Student(int id, string name, int grade, List<Course>? courses)
        {
            Id = id;
            Name = name;
            Grade = grade;
            Courses = courses ?? new List<Course>();
        }
        public Student(string name, int grade, List<Course>? courses)
        {
            Name = name;
            Grade = grade;
            Courses = courses ?? new List<Course>();
        }
    }
}