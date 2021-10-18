using System;

namespace Exercise1
{
    class A
    {
        public string a;
        
    }
    static class Program
    {
        static void Main(string[] args)
        {
            //1
            //integral types
            int intVal = -10;
            uint unitVal = 10;
            byte byteVal = 255;
            sbyte sbyteVal = -128;
            short shortVal = -33;
            ushort ushortVal = 33;
            long longVal = -1000;
            ulong ulongVal = 1000;
            //foating-point types
            float floatVal = -5.324f;
            double doubleVal = 6.433;
            decimal decimalVal = 453.726m;
            //symbolic types
            char charVal = 'a';
            string stringVal = "hello world";
            //boolean type
            bool boolVal = false;
            //special types 
            object objectVal = "anything";
            dynamic dynamicVal = "I can change";
            var varVal = "I know what's on the right";
            //2
            //Comparison operators
            Console.WriteLine("Enter any integer A");
            int value1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter any integer B");
            int value2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Сomparison operations :");
            Console.WriteLine("Are equal = " + (value1 == value2));
            Console.WriteLine("Not equal = " + (value1 != value2));
            Console.WriteLine("А more = " + (value1 > value2));
            Console.WriteLine("A less = " + (value1 < value2));
            Console.WriteLine("A is less than or equal = " + (value1 <= value2));
            Console.WriteLine("А is greater than or equal = " + (value1 >= value2));
            Console.ReadLine();
            Console.Clear();
            //Аrithmetic operators
            Console.WriteLine("Enter any number A - it is always the first");
            double valueАrithmetic1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter any number B");
            double valueАrithmetic2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the sign of the action you want to take (+,-,/,*,%) : ");
            string sign = Console.ReadLine();
            switch (sign)
            {
                case "+":
                    Console.WriteLine(valueАrithmetic1 + valueАrithmetic2);
                    break;
                case "-":
                    Console.WriteLine(valueАrithmetic1 - valueАrithmetic2);
                    break;
                case "*":
                    Console.WriteLine(valueАrithmetic1 * valueАrithmetic2);
                    break;
                case "/":
                    Console.WriteLine(valueАrithmetic1 / valueАrithmetic2);
                    break;
                case "%":
                    Console.WriteLine(valueАrithmetic1 % valueАrithmetic2);
                    break;
            }
            //Increment and Decrement operators
            Console.WriteLine("Enter any integer to increment : ");
            int valIncr = int.Parse(Console.ReadLine());
            int increment = valIncr++;
            Console.WriteLine(valIncr++);
            Console.WriteLine("Enter any integer to decrement : ");
            int valDecr = int.Parse(Console.ReadLine());
            int dicrement = valDecr--;
            Console.WriteLine(valDecr--);
            Console.ReadLine();
            Console.Clear();
            //Logical operators
            bool soreThroat = false;
            bool heat = true;
            if (soreThroat && heat)
            {
                Console.WriteLine("You should see a doctor!");
            }
            else
            {
                Console.WriteLine("Watch your health, you may get sick");
            }
            if (soreThroat ^ heat)
            {
                Console.WriteLine("You get sick");
            }
            if (soreThroat || heat)
            {
                Console.WriteLine("You get sick");
            }
            else
            {
                Console.WriteLine("You are healthy");
            } 
            if (!soreThroat)
            {
                Console.WriteLine("You don't have a sore throat");
            }
            Console.ReadLine();
            Console.Clear();
            // ?: operator
            string wheels;
            string сorrectAnswer = "4";
            Console.WriteLine("how many wheels does the car have?");
            string answer = Console.ReadLine();
            wheels = сorrectAnswer == answer ? "true" : "false";
            Console.WriteLine(wheels);
            Console.ReadLine();
            //Conversion
            byte byteInt = (byte)intVal;
            Console.WriteLine(byteVal);
            if (objectVal is string)
            {
                Console.WriteLine( "objectVal is string type");
            }
            else
            {
                Console.WriteLine( "objectVal is not string type");
            }
            if (objectVal as A != null)
            {
                Console.WriteLine( "objectVal is not string type");
            }
            else
            {
                Console.WriteLine( "objectVal is string type");
            }
        }
    }
}