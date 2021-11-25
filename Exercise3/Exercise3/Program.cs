using System;
using Bogus;
using Exercise3.Domain;
using Person = Bogus.Person;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();
            int count = rnd.Next(10, 15);
            Randomizer.Seed = new Random(count);
            var testPerson = new Faker<Person>()
                .StrictMode(true)
                .RuleFor(o => o.FirstName, f => f.Name.FirstName())
                .RuleFor(o => o.LastName, f => f.Name.LastName())
                .RuleFor(o => o.JobDescription, f => f.Name.JobDescriptor())
                .RuleFor(o => o.JobTitle, f => f.Name.JobTitle())
                .RuleFor(o => o.JobSalary, f => f.Random.Int(300, 2000));
            
            Randomizer.Seed = new Random(count);
            var testCompany = new Faker<Company>()
                .StrictMode(true)
                .RuleFor(o => o.Name, f => f.Name.FirstName())
                .RuleFor(o => o.Country, f => f.Company.CompanyName())
                .RuleFor(o => o.City, f => f.Name.JobDescriptor())
                .RuleFor(o => o.Address, f => f.Name.JobTitle());
            
            /*string Id = Guid.NewGuid().ToString();
            string firstName = new Bogus.DataSets.Name().FirstName();
            string lastName = new Bogus.DataSets.Name().LastName();
            int jobSalary = rnd.Next(300, 2000);
            string jobDescription = new Bogus.DataSets.Name().JobDescriptor();
            string jobTitle = new Bogus.DataSets.Name().JobTitle();
            string companyName = new Bogus.DataSets.Company().CompanyName();
            string companyCountry = new Bogus.DataSets.Address().County();
            string companyCity = new Bogus.DataSets.Address().City();
            string companyAddress = new Bogus.DataSets.Address().FullAddress();*/
        }

        static new Candidate [] generateCandidates()
        {
            return Candidate[count] = new Candidate();
            for (int i = 0; i <= Candidate.Length; i++)
            {
                Candidate[] = $"{id}, {firstName} и тд";
            }
        }
        
        static Employee[] generateEmployees()
        {
            return new[] {new Employee()};
        }
    }
}