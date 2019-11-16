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
                new Person{PersonID=4, FirstName="Jack", LastName="Danil", Email="jack@gmail.com", PhoneNumber="+52789872356"},
                new Person{PersonID=5, FirstName="Bob", LastName="Marl", Email="tina@gmail.com", PhoneNumber="+81297829100"},
            };
            persons.ForEach(person => context.Persons.Add(person));
            context.SaveChanges();

            var employees = new List<Employee>
            {
                new Employee{EmployeeID=1, JobTitle="HR", Salary=500, HiredAt = DateTime.Today.AddMonths(-1), FiredAt = DateTime.Today.AddDays(-5), FK_PersonID=2},
                new Employee{EmployeeID=2, JobTitle="PM", Salary=500, HiredAt = DateTime.Today.AddMonths(-5), FK_PersonID=1},
                new Employee{EmployeeID=3, JobTitle="Analytics", Salary=500, HiredAt = DateTime.Today.AddMonths(-4), FK_PersonID=4}
            };
            employees.ForEach(employee => context.Employees.Add(employee));
            context.SaveChanges();

            var candidates = new List<Candidate>
            {
                new Candidate{CandidateID=1, Vacancy="Analytics", InterviewBeginsAt = new DateTime(2019, 11, 28, 11, 0, 0), FK_PersonID=3},
                new Candidate{CandidateID=2, Vacancy="HR", InterviewBeginsAt = new DateTime(2019, 12, 3, 12, 0, 0), FK_PersonID=5}
            };
            candidates.ForEach(candidate => context.Candidates.Add(candidate));
            context.SaveChanges();
        }
    }
}