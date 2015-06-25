using System;
using System.Collections.Generic;

namespace SchoolPortal.Domain.Models
{
    public class Course
    {
        //Properties to map with the table column's
        public int CourseId { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        //Navigation Properties
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
