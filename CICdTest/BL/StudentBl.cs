using System.Collections.Generic;
using CICdTest.Interfaces;
using CICdTest.Models;

namespace CICdTest.BL
{
    public class StudentBl : IStudentBl
    {
        public List<Student> GetStudents()
        {
            return new List<Student>{ new Student{Id = 1, Name = "Kamal"}, new Student{Id = 2, Name = "Thulani"},  new Student{Id = 3, Name = "Sayuni"}  };
                
        }
    }
}