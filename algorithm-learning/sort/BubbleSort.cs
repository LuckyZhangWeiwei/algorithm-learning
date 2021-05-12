using System;

namespace algorithm_learning.sort
{
    public class BubbleSort
    {
        public static void Sort()
        {
            int[] arr = { 3, 44, 38, 5, 50, 48 };

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine(arr.ToString());
        }
    }
}
