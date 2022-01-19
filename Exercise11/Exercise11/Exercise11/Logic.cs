using System;

namespace Exercise11
{
    public class Logic
    {
        public bool LessThen5(int number)
        {
            if (number > 5)
            {
                return false;
            }
            return true;
        }
        public double Sum(int first, double second)
        {
            return first + second;
        }
        public void Generate()
        {
            throw new ArgumentException();
        }
    }
}