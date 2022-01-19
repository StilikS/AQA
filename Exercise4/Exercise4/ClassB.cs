using System;

namespace Exercise4
{
    public class ClassB<T> : Interface
    {
        public void Sort1()
        {
            
        }
        static void Swap(ref int a, ref int b)
        {
            var t = a;
            a = b;
            b = t;
        }
        public static int[] ShellSort(int[] array)
        {
            var d = array.Length / 2;
            while (d >= 1)
            {
                for (var i = d; i < array.Length; i++)
                {
                    var j = i;
                    while ((j >= d) && (array[j - d] > array[j]))
                    {
                        Swap(ref array[j], ref array[j - d]);
                        j = j - d;
                    }
                }

                d = d / 2;
            }
            return array;
        }

    }
}