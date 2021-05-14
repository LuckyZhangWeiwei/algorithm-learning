using algorithm_learning.sort;
using System;

namespace algorithm_learning
{
    class Program
    {
        static void Main(string[] args)
        {
            //SelectSort.Sort();

            //BubbleSort.Sort();

            //InsertionSort.Sort();
            
            {
                int[] array = new int[] { 19, 97, 09, 17, 01, 08 };
                QucikSort.Sort(array, 0, array.Length - 1);
            }
            
        }
    }
}
