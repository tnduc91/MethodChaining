using System;
using System.Collections.Generic;

namespace MethodChaining.Models
{
    public class CourseRepo
    {
        public List<Course> Get()
        {
            var courses = new List<Course>();
            courses.Add(new Course(1, "React"));
            courses.Add(new Course(2, "Go Lang"));
            courses.Add(new Course(3, "Ruby"));
            courses.Add(new Course(4, "Sql"));

            return courses;
        }
    }
}