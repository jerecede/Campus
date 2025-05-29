namespace Campus.Model
{
    internal class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Subject { get; set; }
        public List<Course> Courses { get; set; }
        public int SchoolId { get; set; }
        public School? School { get; set; }
        public Teacher()
        {
        }

        public Teacher(int id, string name, string subject, List<Course>? courses)
        {
            Id = id;
            Name = name;
            Subject = subject;
            Courses = courses ?? new List<Course>();
        }
        public Teacher(string name, string subject, List<Course>? courses)
        {
            Name = name;
            Subject = subject;
            Courses = courses ?? new List<Course>();
        }

    }
}