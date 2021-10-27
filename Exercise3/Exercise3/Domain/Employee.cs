using System;

namespace Exercise3.Domain
{
    public class Employee : Person, IDisplayable
    {
        public Company Company;
        
        public Employee() /*(string FirstName, string LastName) : base(FirstName, LastName)*/
        {
           
        }

        public void ShowPersonInfo()
        {
            Console.WriteLine($"Hello, I am {FullName}, {JobTitle} in {Company.Name} ({Company.Country}, {Company.City}, {Company.Address}) and my salary {JobSalary}.");
        }
    }
}