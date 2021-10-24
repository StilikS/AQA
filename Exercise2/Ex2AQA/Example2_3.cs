/*using System;
namespace Ex2AQA
{
    public class Example2_3
    {
        public void Display()
        {
            DisplayOverload(100, "200", "300");
            DisplayOverload(200, "100");
            string[] names = {"Akhil", "Ekta", "Arsh"};
            DisplayOverload(200, names, "Ahile");
        }
        private void DisplayOverload(int a, params string[] parameterArray)
        {
            foreach (var i in parameterArray)
                Console.WriteLine(i + " " + a);
        }
    }
}*/