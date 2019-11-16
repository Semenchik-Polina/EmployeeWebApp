using EmployeeDAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace EmployeeDAL
{
    public class EmployeeInitializer: DropCreateDatabaseIfModelChanges<EmployeeContext>
    {
        protected override void Seed(EmployeeContext context)
        {
            var persons = new List<Person>
            {
                new Person{PersonID=1, FirstName="Ann", LastName="Smith", Email="lori@gmail.com"},
                new Person{PersonID=2, FirstName="Lion", LastName="Oldrin", Email="lion@gmail.com"},
                new Person{PersonID=3, FirstName="Tina", LastName="Mosby", Email="tina@gmail.com"},
            };
            persons.ForEach(person => context.Persons.Add(person));
            context.SaveChanges();

            var employees = new List<Employee>
            {
                new Employee{EmployeeID=1, JobTitle="HR", Salary=500, HiredAt = DateTime.Today.AddMonths(-1), FiredAt = DateTime.Today.AddDays(-5), FK_PersonID=2},
                new Employee{EmployeeID=2, JobTitle="PM", Salary=500, HiredAt = DateTime.Today.AddMonths(-5), FK_PersonID=1}
            };
            employees.ForEach(employee => context.Employees.Add(employee));
            context.SaveChanges();

            var candidates = new List<Candidate>
            {
                new Candidate{CandidateID=1, Vacancy="Analytics", FK_PersonID=3}
            };
            candidates.ForEach(candidate => context.Candidates.Add(candidate));
            context.SaveChanges();
        }
    }
}