using System;
using System.Collections.Generic;
using Bogus;

namespace Exercise3.Domain
{
    public class Employee : Person, IDisplayable
    {
        private Company _company;
        public Employee()
        {
            CreateCompany();
        }
        public void CreateCompany() 
        {
            var testCompany = new Faker<Company>()
                .StrictMode(true)
                .RuleFor(o => o.Name, f => f.Name.FirstName())
                .RuleFor(o => o.Country, f => f.Company.CompanyName())
                .RuleFor(o => o.City, f => f.Name.JobDescriptor())
                .RuleFor(o => o.Address, f => f.Name.JobTitle());
            _company = testCompany.Generate();
        }

        public void ShowPersonInfo()
        {
            Console.WriteLine($"Hello, I am {FullName}, {JobTitle} in {_company.Name} ({_company.Country}, {_company.City}, {_company.Address}) and my salary {JobSalary}.");
        }
    }
}