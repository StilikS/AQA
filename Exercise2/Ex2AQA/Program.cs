namespace Ex2AQA
{
    class Program1
    {
        static void Main(string[] args)
        {
            //example 1
            /*var overload = new Overload();
            overload.DisplayOverload(100);
            overload.DisplayOverload("metod overloading");
            overload.DisplayOverload("metod overloading", 100);*/
            
            //example2 
            /*var overland = new Overload();
            overland.Display();*/
            
            //examole 3
           /* ClassA a = new ClassA();
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
            ClassA classA = new ClassC();
            ClassB classB = new ClassC();
            classA.XXX();
            classB.XXX();
        }
    }
}
