using System;

namespace Ex2AQA
{
    class Overload
    {
        public void DisplayOverload(int a)
        {
            Console.WriteLine($"DisplayOverload: {a}");
        }
        public void DisplayOverload(string a)
        {
            Console.WriteLine($"DisplayOverload: {a}");
        }
        public void DisplayOverload(string a, int b)
        {
            Console.WriteLine($"DisplayOverload: {a} {b}");
        }
        /*public void DisplayOverload() {}
        public int DisplayOverload() {}
        static void DisplayOverload(int a) {}
        public void DisplayOverload(int a) {}
        public void DisplayOverload(string a) {}
        public void DisplayOverload(out int a)
        {
            a = 100;
        }
        public void DisplayOverload(ref int a) {}
        public void DisplayOverload(int a, string a) {}
        public void Display(int a) {string a}*/
    }
} 