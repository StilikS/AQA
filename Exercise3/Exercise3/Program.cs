using System;
using System.Collections.Generic;
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
            string[] persons = {"Employee",  "Candidate"};
            var employees = new List<Employee>();
            var candidates = new List<Candidate>();
            var userFactory = new UserFactory();
            
            for (int i = 0; i < count; i++)
            {
                userFactory.GetInstance( persons[rnd.Next(2)], employees, candidates);
            }
            foreach (var person in employees)
            {
                person.ShowPersonInfo();
                Console.WriteLine();
            }
            foreach (var person in candidates)
            {
                person.ShowPersonInfo();
                Console.WriteLine();
            } 
        }
        
    }
}