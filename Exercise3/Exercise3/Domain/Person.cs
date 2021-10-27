using System;
using Bogus;

namespace Exercise3.Domain
{
    public class Person
    {
        public string Id {get; set; }
        public string FirstName {get; set;}
        public string LastName{get; set;}
        public string JobTitle{get; set;}
        public string JobSalary{get; set;}
        public string JobDescription{get; set;}
        private string fullName;
        public string FullName
        {
            get
            {
                return fullName;
            }
            set
            {
                FullName = $"{FirstName} {LastName}";
            }
        }
        /*public Person(string FirstName, string LastName)
        {
           FullName = $"{FirstName} {LastName}";
        }*/
    }
}    
