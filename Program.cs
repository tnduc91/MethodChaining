using System;
using MethodChaining.Fluent;
using System.Collections.Generic;
using System.Linq;

namespace MethodChaining
{
    class Program
    {
        static void Main(string[] args)
        {
            new FluentEnroller()
                .Enroll()
                .WithStudents(students => students.Where(s => !s.IsRegistered))
                .ForCourse("sql")
                .Save();
        }
    }
}
