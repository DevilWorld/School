using System;

namespace EntityTest.Models
{
    class HomeWork      //Many-to-many relationship with additional fields
    {
        public int HomeWorkId { get; set; }

        //Foreign Key properties
        public int StudentId { get; set; }
        public int ClassId { get; set; }

        //Navigation properties
        public virtual Student Student { get; set; }
        public virtual Class Class { get; set; }

        //Additional Properties
        public string HomeWorkContent { get; set; }
        public int CreatedBy { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime CompletedOn { get; set; }
    }
}
