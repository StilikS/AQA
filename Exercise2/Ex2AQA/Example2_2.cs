/*using System;
namespace Ex2AQA
{
    public class Example2_2
    {
        public void Display()
        {
            DisplayOverload(100, 200, 300);
            DisplayOverload(200, 100);
            DisplayOverload(200);
        }
        private void DisplayOverload(int a, params int[] parameterArray)
        {
            foreach (var i in parameterArray)
                Console.WriteLine(i + " " + a);
        }
        private void DisplayOverload(int a, params string[] parameterArray)
        {
            foreach (var i in parameterArray)
                Console.WriteLine(i + " " + a);
        }
    }
}*/