using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SchoolPortal.Domain.Models;

namespace SchoolPortal.Domain.Repository
{
    public interface IStudentRepository
    {
        void AddStudent(Person person);
        void UpdateStudent(int intStudentId);
        void DeletStudent(int intStudentId);
        IEnumerable<Person> GetAllStudents();
        IEnumerable<Person> GetStudentDetails(int intStudentId);
    }
}