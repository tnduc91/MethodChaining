using System.Collections.Generic;

namespace MethodChaining.Models
{
    public class Student
    {
        public int Id;
        public string Name;
        public bool IsRegistered;

        public Student(int id, string name, bool isRegistered)
        {
            Id = id;
            Name = name;
            IsRegistered = isRegistered;
        }
    }
}