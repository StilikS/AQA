using System;
namespace Ex2AQA
{
    public class Encapsulation
    {
        private int age;
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
        }
    }
}