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
                if (age <= 0 && age <= 100) throw new ArgumentException("Value should be positive");
                age= value;
            }

        }
    }
}