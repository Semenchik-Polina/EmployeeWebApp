using EmployeeDAL.Entities;
using System.Data.Entity;

namespace EmployeeDAL
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext() : base("Employees")
        { }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Candidate> Candidates { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            
            modelBuilder.Entity<Employee>()
                .HasRequired(employee => employee.Person)
                .WithMany(person => person.Employees)
                .HasForeignKey(employee => employee.FK_PersonID);

            modelBuilder.Entity<Candidate>()
                .HasRequired(candidate => candidate.Person)
                .WithMany(person => person.Candidates)
                .HasForeignKey(candidate => candidate.FK_PersonID);
        }
    }
}