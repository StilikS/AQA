using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            int[] array1 = {1, 56, 34, 2, 897, 342, 55, 765};
            int[] array2 = {1, 5456, 11, 90, 87, 55, 545, 765};
            IEnumerable<int> result = array1.Intersect(array2);
            var arrayresult = result.ToArray();
            foreach (var duplicate in arrayresult)
            {
                Console.WriteLine(duplicate);  
            }
            //2
            Queue<int> qu = new Queue<int>();
            qu.Enqueue(3); 
            qu.Enqueue(4); 
            qu.Enqueue(1); 
            qu.Enqueue(7); 
            qu.Enqueue(5); 
            qu.Enqueue(6); 
            qu.Enqueue(9); 
            qu.Enqueue(8);
            Queue<int> qu2 = new Queue<int>();
            int max = int.MinValue;
            int min = int.MaxValue;
            int a;
            int b;
            int sum = 0; 
            while (qu.Count > 0)
            {
                a = qu.Dequeue();
                if (a > max)
                {
                    max = a;
                    qu2.Enqueue(a);
                }
                else
                    qu2.Enqueue(a);
            }
            while (qu2.Count > 0)
            {
                b = qu2.Dequeue();
                if (b < min)
                {
                    min = b;
                    qu.Enqueue(b);
                }
                else
                    qu.Enqueue(b);
            }
            int[] gh = qu.ToArray();
            for (var i = 0; i < gh.Length; i++)
            {
                if (i >= min && i <= max)
                    sum += gh[i];
            }
            /*c = qu.Dequeue();
            if (c == max || c == min)
            {
                sum += c;
                qu2.Enqueue(c);
                
            }
            else
                qu2.Enqueue(c);*/
            
            
            //3
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1); 
            queue.Enqueue(2); 
            queue.Enqueue(3); 
            queue.Enqueue(4); 
            queue.Enqueue(5); 
            queue.Enqueue(6); 
            queue.Enqueue(7); 
            queue.Enqueue(8);
            queue.Enqueue(9);
            queue.Enqueue(10);
            while (queue.Count > 1)
            {
                queue.Enqueue(queue.Dequeue());
                queue.Dequeue();  
            }
            Console.WriteLine($"Последний элемент:{queue.Dequeue()} ");
            List<int> list = new List<int>() {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            bool delete = false;
            while (list.Count > 1)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (delete)
                    {
                        list.RemoveAt(i--);
                        delete = false;
                    }
                    else
                    {
                        delete = true; 
                    }
                }
            }
            foreach (var lperson in list)
            {
                Console.WriteLine(lperson);
            }
            //4
            /*int []arr = {5, 9, 7, 6, 1, 3, 10};
            BubbleSort(arr);
            Console.WriteLine("Sorted array");
            PrintArray(arr);*/



        }
    }
}