using System;
using Bogus;

namespace Exercise3.Domain
{
    class Person

    {
        private int count;
        
        public int Count()
        {
            return count;
        }

        public int GetPersonsCount()
        {
            Random rnd = new Random();
            count = rnd.Next(10, 15);
            return count;
        }

        public string CreateId()
        {
            string id = Guid.NewGuid().ToString();
            return id;
        }
        public string[] CreateIdList() 
        {
            string[] idList = new string[count];
            for (int i = 0; i <= idList.Length; i++)
            {
                idList[i] = CreateId();
            }
            return idList;
        }
        
        public string CreateFirstName()
        {
            string firstName = new Bogus.DataSets.Name().FirstName();
            return firstName;
        }
        public string[] CreateFNList()
        {
            string[] firstNList = new string[count];
            for (int i = 0; i < firstNList.Length; i++)
            {
                firstNList[i] = CreateFirstName();
            }
            return firstNList;
        }
        
        public string CreateLastName()
        {
            string lastName = new Bogus.DataSets.Name().LastName();
            return lastName;
        }
        public string[] CreateLNList()
        {
            string[] lastNList = new string[count];
            for (int i = 0; i < lastNList.Length; i++)
            {
                lastNList[i] = CreateLastName();
            }

            return lastNList;
        }

        
        public string CreateJobSalary()
        {
            var Salary = new Faker();
            string jobSalary = Convert.ToString(Salary.Random.Number(300, 2000));
            return jobSalary;
        }
        public string[] CreateJSalaryList()
        {
            string[] salaryList = new string[count];
            for (int i = 0; i < salaryList.Length; i++)
            {
               salaryList[i] = CreateJobSalary();
            }

            return salaryList;
        }

        
        public string CreateJobDescription()
        {
            string jobDescription = new Bogus.DataSets.Name().JobDescriptor();
            return jobDescription;
        }
        public string[]  CreateJDescriptionList()
        {
            string[] descriptionList = new string[count];
            for (int i = 0; i < descriptionList.Length; i++)
            {
                descriptionList[i] = CreateJobDescription();
            }

            return descriptionList;
        }

        
        public string CreateJobTitle()
        {
            string jobTitle = new Bogus.DataSets.Name().JobTitle();
            return jobTitle;
        }
        public string[]  CreateJTitleList()
        {
            string[] titleList = new string[count];
            for (int i = 0; i < titleList.Length; i++)
            {
                titleList[i] = CreateJobSalary();
            }
            return titleList;
        }
    }
}

