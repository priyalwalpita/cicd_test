using System.Collections.Generic;
using CICdTest.Models;

namespace CICdTest.Interfaces
{
    public interface IStudentBl
    {
        List<Student> GetStudents();
    }
}