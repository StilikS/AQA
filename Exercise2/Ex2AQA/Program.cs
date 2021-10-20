using System;
using Microsoft.VisualBasic;

namespace Ex2AQA
{
    class Program1
    {
        static void Main(string[] args)
        {
            //Example 1
            /*var overload = new Overload();
            overload.DisplayOverload(100);
            overload.DisplayOverload("metod overloading");
            overload.DisplayOverload("metod overloading", 100);*/
            //Example 2 
            /* var overland = new Overload();
             overland.Display();*/
            //Example 3
            /*ClassA a = new ClassA();
            a.Display1();*/
            //examole 4
            /*{
                ClassB b = new ClassB();
                b.Display2();
            }*/
            //Example 5
            /*{
                ClassA classB = new ClassB();
            }*/
            //Example 6
            /*ClassA classA = new ClassC();
            ClassB classB = new ClassC();
            classA.XXX();
            classB.XXX();*/
            //encapsulation
            Encapsulation Encapsulation = new Encapsulation();
            Console.WriteLine("Write your age: ");
            Encapsulation.Age = int.Parse(Console.ReadLine());
            Console.WriteLine($"Your age: {Encapsulation.Age} ");
        }
    }
}
