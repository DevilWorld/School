using System.Data.Entity;
using SchoolPortal.Domain.Model;
using SchoolPortal.Infrastructure.Data.Mapping;


namespace SchoolPortal.Infrastructure
{
    public class EFDataContext : DbContext
    {
        public EFDataContext()
            : base("name=SchoolContext")
        { }

        //public DbSet<Course> Courses { get; set; }
        //public DbSet<Person> Persons { get; set; }

        protected override void OnModelCreating(DbModelBuilder model)
        {
            //Add this code, otherwise, we get model backing exception
            Database.SetInitializer<EFDataContext>(null);
            
            //model.Configurations.Add(new PersonMap());
        }
    }
}
