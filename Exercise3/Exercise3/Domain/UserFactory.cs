using System;

namespace Exercise3.Domain
{
    public class UserFactory
    {
        public Person GetInstance(Type type)
        {
            if (type == typeof(Employee) || type == typeof(Candidate))
            {
                if (type == typeof(Employee))
                {
                    return new Employee();
                }
                else
                {
                    return new Candidate();
                }
            }
            else
            { 
                return null;
            }
        }
       
        
    }
}