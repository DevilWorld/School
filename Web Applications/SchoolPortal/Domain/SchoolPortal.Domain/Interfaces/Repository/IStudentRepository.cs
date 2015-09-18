using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SchoolPortal.Domain.Model;

namespace SchoolPortal.Domain.Repository
{
    public interface IStudentRepository
    {
        void AddStudent(Student person);
        void UpdateStudent(int intStudentId);
        void DeletStudent(int intStudentId);
        IEnumerable<Student> GetAllStudents();
        IEnumerable<Student> GetStudentDetails(int intStudentId);
    }
}