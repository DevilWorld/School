using System;
using System.Collections.Generic;

namespace SchoolPortal.Domain.Models
{
    public class Person
    {
        //Properties to map with the table column's
        public int PersonId { get; set; }
        public string UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Sex { get; set; }
        public DateTime Dob { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
        public bool Active { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        //Navigation Properties
        //public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
