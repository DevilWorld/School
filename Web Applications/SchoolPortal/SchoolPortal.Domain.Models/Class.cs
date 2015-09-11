using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityTest.Models
{
    class Class
    {
        public int ClassId { get; set; }
        public string ClassName { get; set; }
        public DateTime TeacherFromDate { get; set; }
        public DateTime TeacherToDate { get; set; }

        //Foreign Key
        public int TeacherId { get; set; }
        public int SubjectId { get; set; }

        //Navigation Property for Teacher
        public virtual Teachers Teacher { get; set; }
        //Navigation Property for Subject
        public virtual Subject Subject { get; set; }

        public virtual ICollection<StudentClasses> StudentClass { get; set; }

        public virtual ICollection<HomeWork> HomeWork { get; set; }
    }
}
