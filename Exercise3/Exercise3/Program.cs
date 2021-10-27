using System;
using Exercise3.Domain;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int count = rnd.Next(10, 15);
            string Id = Guid.NewGuid().ToString();
            string firstName = new Bogus.DataSets.Name().FirstName();
            string lastName = new Bogus.DataSets.Name().LastName();
            int jobSalary = rnd.Next(300, 2000);
            string jobDescription = new Bogus.DataSets.Name().JobDescriptor();
            string jobTitle = new Bogus.DataSets.Name().JobTitle();
            string companyName = new Bogus.DataSets.Company().CompanyName();
            string companyCountry = new Bogus.DataSets.Address().County();
            string companyCity = new Bogus.DataSets.Address().City();
            string companyAddress = new Bogus.DataSets.Address().FullAddress();
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