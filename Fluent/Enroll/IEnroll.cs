using System;
using System.Collections.Generic;
using MethodChaining.Models;

namespace MethodChaining.Fluent
{
    public interface IEnroll
    {
        IEnroll WithStudents(Func<IEnumerable<Student>, IEnumerable<Student>> func);
        IEnroll ForCourse(string course);
        void Save();
    }
}