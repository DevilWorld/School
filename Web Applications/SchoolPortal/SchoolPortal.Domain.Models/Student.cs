using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityTest.Models
{
    class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public string Sex { get; set; }

        //Navigation property, which acts as a collection of the child
        public virtual ICollection<Address> Addresses { get; set; }

        //Navigation property
        public virtual ICollection<Parent> Parents { get; set; }

        public virtual ICollection<StudentClasses> StudentClass { get; set; }

        public virtual ICollection<HomeWork> HomeWork { get; set; }
    }
}
