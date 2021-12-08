using System;
using Bogus;

namespace Exercise3.Domain
{
    public class Person
    {
        public Guid Id { get; set; }
        public string FirstName {get; set;}
        public string LastName{get; set;}
        public string JobTitle{get; set;}
        public int JobSalary{get; set;}
        public string JobDescription{get; set;}
        public string FullName 
        {
            get
            {
                return ($"{FirstName} {LastName}");
            } 
        }
    }
}    
