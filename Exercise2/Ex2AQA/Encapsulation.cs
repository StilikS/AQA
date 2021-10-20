using System;

namespace Ex2AQA
{
    public class Encapsulation
    {
        private int age;
        public int SetAge
        {
            set
            {
                age = value;
                IfAge();
            }
        }
        private void IfAge()
        {
            if (age >= 0 && age <= 100)
            {
                GetAge();
            }
            else
            {
                Error();
            }
        }
        public void GetAge()
        {
            Console.WriteLine("Accepted");
        }
        public void Error()
        {
            Console.WriteLine("Error");
        }
    }
}