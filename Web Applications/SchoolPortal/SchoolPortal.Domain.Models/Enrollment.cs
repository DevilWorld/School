namespace SchoolPortal.Domain.Models
{
    public class Enrollment
    {
        public int EnrollmentId { get; set; }
        public int PersonId { get; set; }
        public int CourseId { get; set; }

        //Navigation Properties
        public Person Person { get; set; }
        public Course Course { get; set; }
    }
}
