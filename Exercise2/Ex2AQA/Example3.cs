using System;
namespace Ex2AQA
{
    class Example3 : ClassB {}
    class ClassB
    {
        public int x = 100;
        public void Display1()
        {
            Console.WriteLine("ClassB Display1 ");
        }
        public void Display2()
        {
            Console.WriteLine("ClassB Display2");
        }
    }
}