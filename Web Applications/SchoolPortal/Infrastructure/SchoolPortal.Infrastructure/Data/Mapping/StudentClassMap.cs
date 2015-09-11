using System;
using EntityTest.Models;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityTest.Mapper
{
    class StudentClassMap:EntityTypeConfiguration<StudentClasses>
    {
        public StudentClassMap()
        {
            ToTable("tblStudentClasses");

            HasKey(pk => new { pk.StudentId, pk.ClassId });

            Property(p => p.StudentClassId).HasColumnName("StudentClassId").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            
            Property(p => p.FromDate).HasColumnName("FromDate");
            Property(p => p.ToDate).HasColumnName("ToDate");

            HasRequired(a => a.Student)
                .WithMany(sc => sc.StudentClass)
                .HasForeignKey(t => t.StudentId);

            HasRequired(c => c.Class)
                .WithMany(sc => sc.StudentClass)
                .HasForeignKey(fk => fk.ClassId);

        }
    }
}
