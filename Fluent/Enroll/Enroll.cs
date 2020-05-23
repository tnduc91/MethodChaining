using System;
using System.Collections.Generic;
using MethodChaining.Models;
using System.Linq;
namespace MethodChaining.Fluent
{
    public class Enroll : IEnroll
    {
        private IEnumerable<Student> _filteredStudents{get;set;}
        private Course _course{get;set;}

        public IEnroll ForCourse(string courseName)
        {
            var courseRepo = new CourseRepo();
            var courses = courseRepo.Get();
            _course = courses.Where(c => c.Name.ToLower().Contains(courseName)).FirstOrDefault();
            return this as IEnroll;
        }

        public void Save()
        {
            if (_course == null)
            {
                Console.WriteLine("The course is not found!");
                return;
            }

            foreach(var s in _filteredStudents)
            {
                Console.WriteLine(s.Name + " - " + _course.Name);
            }
        }

        public IEnroll WithStudents(Func<IEnumerable<Student>, IEnumerable<Student>> func)
        {
            var studentRepo = new StudentRepo();
            var students = studentRepo.Get();
            _filteredStudents = func.Invoke(students);   
            return this as IEnroll;
        }


    }
}