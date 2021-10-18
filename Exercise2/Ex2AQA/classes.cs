using System;

namespace Ex2AQA
{
    //Example 1
   /* class Overload
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
     public void DisplayOverload() {}
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
     public void Display(int a) {string a}
    }*/
   //Example 2
    /*class Overload
    {
        private string name = "Akhil";

        public void Display()
        {
            Display2(ref name, ref name);
            Console.WriteLine(name);
        }

        private void Display2(ref string x, ref string y)
        {
            Console.WriteLine(name);
            x = "Akhil 1";
            Console.WriteLine(name);
            x = "Akhil 2";
            Console.WriteLine(name);
            x = "Akhil 3";
        }
    }*/
    /*public class Overload
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
    }*/
    /*public class Overload
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
    }*/
    /*public class Overload
    {
        public void Display()
        {
            int[] numbers = {10, 20, 20};
            DisplayOverload(40, numbers);
            Console.WriteLine(numbers[1]);
        }
        private void DisplayOverload(int a, params int[] parameterArray)
        {
            parameterArray[1] = 3000;
        }

    }*/
    
   /* public class Overload
    {
        public void Display()
        {
            int number = 102;
            DisplayOverload(40, 1000, number, 4000);
            Console.WriteLine(number);
        }

        private void DisplayOverload(int a, params int[] parameterArray)
        {
            parameterArray[1] = 3000;
        }

    }*/
    
    /*public class Overload
    {
        public void Display()
        {
            DisplayOverload(200);
            DisplayOverload(200, 300);
            DisplayOverload(200, 300, 500, 600);
        }

        private void DisplayOverload(int x, int y)
        {
            Console.WriteLine("The two integers " + x + " "+ y);
        }

        private void DisplayOverload(params int[] parameterArray)
        {
            Console.WriteLine(parameterArray);
        }
    }*/

    //Example 3
   /* partial class ClassA{}
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

    partial class ClassA : ClassB
    {
        
        public void Display1()
        {
            Console.WriteLine("ClassA Display1 ");
            base.Display1();
        }
        
    }*/
   
   
   //Example 4
   /* class ClassB
    {
        public int x = 100;
        public void Display1()
        {
            Console.WriteLine("ClassB Display1 ");
        }
        
    }
    partial class ClassA : ClassB
    {
        
        public void Display2()
        {
            Console.WriteLine("ClassA Display2 ");
        }
        
    }*/
    
    //Example 5
    /*public abstract class ClassA
    {
        public int a;
        public void XXX() { }

        abstract public void YYY();
    }

    public class ClassB : ClassA
    {
        public int YYY() {}
    }*/

    /* public abstract class ClassA
     {
         public int a;
         public void XXX() { }
 
         abstract public void YYY();
     }
 
     public class ClassB : ClassA
     {
         public override int YYY() {}
     }*/

   /*public abstract class ClassA
   {
       public int a;
       public void XXX() { }

       abstract public void YYY();
   }

   public class ClassB : ClassA
   {
       public override int YYY()
       {
           base.YYY();
       }
   }*/
   
   //Example 6
   public class ClassA
   {
       public virtual void XXX()
       {
           Console.WriteLine("ClassA XXX");
       }
   }

   public abstract class ClassB : ClassA
   {
       public new abstract void XXX();
   }

   public class ClassC : ClassB
   {
       public override void XXX()
       {
           System.Console.WriteLine("ClassC XXX");
       }
   }

   





}
    
    
        
                
                
                


            

            
            



    
