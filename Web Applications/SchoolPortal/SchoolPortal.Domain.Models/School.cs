using System;
using System.Collections.Generic;

namespace EntityTest.Models
{
    class School
    {
        public int SchoolId { get; set; }
        public string SchoolName { get; set; }
        //public int PrincipalId { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }

        //Navigation Property 
        public Principal Principal { get; set; }

        //Navigation Property to Teacher
        public virtual ICollection<Teachers> Teacher { get; set; }
    }
}
