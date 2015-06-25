using System.Data.Entity.ModelConfiguration;
using SchoolPortal.Domain.Models;

namespace SchoolPortal.Infrastructure.Data.Mapping
{
    public class PersonMap:EntityTypeConfiguration<Person>
    {
        public PersonMap()
        {
            //Tell to which table, does our model maps to
            ToTable("tblPerson");

            //Model property to Column mapping
            Property(c => c.PersonId).HasColumnName("PersonID");
            Property(c => c.UserId).HasColumnName("UserID");
            Property(c => c.FirstName).HasColumnName("FirstName");
            Property(c => c.LastName).HasColumnName("LastName");
            Property(c => c.MiddleName).HasColumnName("MiddleName");
            Property(c => c.Sex).HasColumnName("Sex");
            Property(c => c.Dob).HasColumnName("DOB");
            Property(c => c.Active).HasColumnName("Active");
            Property(c => c.CreatedBy).HasColumnName("CreatedBy");
            Property(c => c.CreatedDate).HasColumnName("CreatedDate");
            Property(c => c.ModifiedBy).HasColumnName("ModifiedBy");
            Property(c => c.ModifiedDate).HasColumnName("ModifiedDate");
        }
    }
}
