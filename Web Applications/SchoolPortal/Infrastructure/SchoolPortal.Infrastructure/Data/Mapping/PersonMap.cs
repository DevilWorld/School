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
            Property(c => c.UserId).HasColumnName("UserID").IsOptional();
            Property(c => c.FirstName).HasColumnName("FirstName").IsOptional();
            Property(c => c.LastName).HasColumnName("LastName").IsOptional();
            Property(c => c.MiddleName).HasColumnName("MiddleName").IsOptional();
            Property(c => c.Sex).HasColumnName("Sex").IsOptional();
            Property(c => c.Dob).HasColumnName("DOB").IsOptional();
            Property(c => c.Active).HasColumnName("Active").IsOptional();
            Property(c => c.CreatedBy).HasColumnName("CreatedBy").IsOptional();
            Property(c => c.CreatedDate).HasColumnName("CreatedDate").IsOptional();
            Property(c => c.ModifiedBy).HasColumnName("ModifiedBy").IsOptional();
            Property(c => c.ModifiedDate).HasColumnName("ModifiedDate").IsOptional();
        }
    }
}
