using System;
using System.Collections.Generic;
using System.Text;

namespace algorithm_learning.sort
{
    public class InsertionSort
    {
        public static void Sort()
        {
            int[] arr = { 3, 44, 38, 5, 50, 48 };

            for (int i = 0; i < arr.Length; i++)
            {
                int insertValue = arr[i];

                int preInsertIndex = i - 1;

                while (preInsertIndex > 0 && insertValue < arr[preInsertIndex])
                {
                    arr[preInsertIndex + 1] = arr[preInsertIndex];
                    preInsertIndex--;
                }


                arr[preInsertIndex + 1] = insertValue;
            }

            Console.WriteLine(arr.ToString());
        }
    }
}
