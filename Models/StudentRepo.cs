using System;
using System.Collections.Generic;

namespace MethodChaining.Models
{
    public class StudentRepo
    {
        public List<Student> Get()
        {
            var students = new List<Student>();
            students.Add(new Student(1, "Pai Lee", true));
            students.Add(new Student(2, "Danny", true));
            students.Add(new Student(3, "Wuyou", false));
            students.Add(new Student(4, "Rajashri", false));

            return students;
        }
    }
}