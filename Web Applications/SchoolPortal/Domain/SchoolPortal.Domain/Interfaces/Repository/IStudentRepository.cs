using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SchoolPortal.Domain.Model;

namespace SchoolPortal.Domain.Interfaces.Repository
{
    public interface IStudentRepository
    {
        void AddStudent(Student person);
        void UpdateStudent(Student student);
        void DeletStudent(Student student);
        IEnumerable<Student> GetAllStudents();
        IEnumerable<Student> GetStudentDetails(int intStudentId);
        void Save();
    }
}