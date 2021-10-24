using System;
namespace Ex2AQA
{
    public class Encapsulation1
    {
        private int age;
        public int Age
        {
            get { return age; }
            set
            {
<<<<<<< HEAD
                if (value <= 0) throw new ArgumentException("Value should be positive");
                age = value;
=======
                if (age <= 0) throw new ArgumentException("Value should be positive");
                age= value;
>>>>>>> 33bd859358d504433b2509b7af9eea87786fca52
            }
        }
    }
}
