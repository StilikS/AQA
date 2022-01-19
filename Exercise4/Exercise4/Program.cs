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
            var set1 = new HashSet<int>();
            var set2 = new HashSet<int>();
            var set3 = new HashSet<int>();
            int[] array1 = {1, 56, 34, 2, 897, 342, 55, 765};
            int[] array2 = {1, 5456, 11, 90, 87, 55, 545, 765};
            for (int i = 0; i < array1.Length; i++)
            {
                set1.Add(array1[i]);
                set2.Add(array2[i]);
            }

            foreach (var item in set1)
            {
                if (set2.Contains(item))
                {
                    set3.Add(item);
                }
            }

            Console.Write("Set3: ");
            foreach (var item in set3)
            {
                Console.Write($"{item}, ");
            }

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

                int c;
                int d;
                if (min > max)
                {
                    c = max;
                    d = min;
                }
                else
                {
                    c = min;
                    d = max;
                }
                int[] gh = qu.ToArray();
                for (; c <= d; c++)
                { 
                    sum += gh[c];
                }

                Console.WriteLine(sum);
                //3
                Queue<int> queue = new Queue<int>();
                
                for (int i = 1; i < 11; i++)
                    queue.Enqueue(i);
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
                var intl = new ClassA<int[]>();
                var strl = new ClassB<string[]>();
                Console.WriteLine(intl.BubbleSort());
                Console.WriteLine(strl.ShellSort());
        }
    }
}