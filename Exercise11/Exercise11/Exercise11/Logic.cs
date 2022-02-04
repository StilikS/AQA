using System;
using System.Linq;

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
        public int[] GetArray(int[] arr1)
        {
            int[] arr2 = new int[arr1.Length];
            for (int i = 0; i < arr1.Length; i++)
            {
                arr2 = arr1.Select(x => x+2).ToArray();

            }
            return arr2;
        }
    }
}