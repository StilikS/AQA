using System;

namespace Exercise4
{
    public class ClassB<T> : Inte
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
        static int[] StoogeSort(int[] array, int startIndex, int endIndex)
        {
            if (array[startIndex] > array[endIndex])
            {
                Swap(ref array[startIndex], ref array[endIndex]);
            }

            if (endIndex - startIndex > 1)
            {
                var len = (endIndex - startIndex + 1) / 3;
                StoogeSort(array, startIndex, endIndex - len);
                StoogeSort(array, startIndex + len, endIndex);
                StoogeSort(array, startIndex, endIndex - len);
            }

            return array;
        }
        static int[] StoogeSort(int[] array)
        {
            return StoogeSort(array, 0, array.Length - 1);
        }

    }
}