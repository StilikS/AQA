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
                if (value <= 0) throw new ArgumentException("Value should be positive");
                age = value;
            }
        }
    }
}