using System;
using System.Collections.Generic;
using Bogus;

namespace Exercise3.Domain
{
    public class UserFactory
    {
        public void GetInstance(string person, List<Employee> employees, List<Candidate> candidates)
        {
            if (person == "Employee")
            {
                CreatePerson<Employee>(employees);
               
            }
            else if( person == "Candidate" )
            { 
                CreatePerson<Candidate>(candidates);
            }
        }
        private void CreatePerson<T>(List<T> persons) where T : Person
        {
            var testPerson = new Faker<T>()
                .StrictMode(true)
                .RuleFor(c => c.Id, f => Guid.NewGuid())
                .RuleFor(o => o.FirstName, f => f.Name.FirstName())
                .RuleFor(o => o.LastName, f => f.Name.LastName())
                .RuleFor(o => o.JobDescription, f => f.Name.JobDescriptor())
                .RuleFor(o => o.JobTitle, f => f.Name.JobTitle())
                .RuleFor(o => o.JobSalary, f => f.Random.Int(300, 2000));
            persons.Add(testPerson.Generate()); 
        }
    }
}