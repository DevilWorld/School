using System;
using System.Collections.Generic;
using System.Linq;
using SchoolPortal.Domain.Repository;
using SchoolPortal.Domain.Models;
using System.Data.Entity.Validation;

namespace SchoolPortal.Infrastructure.Repository
{
    public class StudentRepository : IStudentRepository
    {

        EFDataContext _context;

        public void AddStudent(Person person)
        {
            using (_context = new EFDataContext())
            {
                _context.Persons.Add(person);
                try
                {
                    _context.SaveChanges();
                }
                catch (DbEntityValidationException dbex)
                {
                    foreach (var ex in dbex.EntityValidationErrors)
                    {
                        foreach (var e in ex.ValidationErrors)
                        {
                            var property = e.PropertyName;
                            var error = e.ErrorMessage;
                        }
                    }
                }
            }
        }

        public void UpdateStudent(int intStudentId) { throw new NotImplementedException(); }
        public void DeletStudent(int intStudentId) { throw new NotImplementedException(); }
        public IEnumerable<Person> GetAllStudents()
        {
            using (_context = new EFDataContext())
            {
                var allPersons = _context.Persons.ToList();
                return allPersons;
            }
        }
        public IEnumerable<Person> GetStudentDetails(int intStudentId) { throw new NotImplementedException(); }
    }
}
