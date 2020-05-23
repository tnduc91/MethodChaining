namespace MethodChaining.Models
{
    public class Course
    {
        public int Id;
        public string Name;
        public Course(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}