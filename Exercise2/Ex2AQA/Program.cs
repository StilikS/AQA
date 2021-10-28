using System;
using Microsoft.VisualBasic;

namespace Ex2AQA
{
    class Program1
    {
        static void Main(string[] args)
        {
            //Example 1
            var overload = new Example1();
            overload.DisplayOverload(100);
            overload.DisplayOverload("metod overloading");
            overload.DisplayOverload("metod overloading", 100);
            //Example 2 
            var overland = new Example2_3();
            overland.Display();
            //Example 3
            Example3 a = new Example3();
            a.Display1();
            //examole 4
            /*Example4 b = new Example4();
            b.Display2();*/
            //Example 5
            /*Example5_2_2 a = new Example5_2_2();*/
            //Example 6
            /*ClassA classA = new ClassC();
            ClassB classB = new ClassC();
            classA.XXX();
            classB.XXX();*/
            //encapsulation
            Encapsulation1 encapsulation = new Encapsulation1();
            Console.WriteLine("Write your age: ");
            encapsulation.Age = int.Parse(Console.ReadLine());
            Console.WriteLine(encapsulation.Age);
            //polymorphism
            Driver person = new Driver();
            person.Drive(new Sportcar());
            person.Drive(new Car());
        }
    }
}
