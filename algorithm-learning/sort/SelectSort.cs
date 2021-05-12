using System;

namespace algorithm_learning.sort
{
    public class SelectSort
    {
        public static void Sort()
        {
            int[] arr = { 3, 44, 38, 5, 50, 48 };
            
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int index = i;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[index])
                    {
                        index = j;
                    }
                }

                int temp = arr[index];
                arr[index] = arr[i];
                arr[i] = temp;

            }

            Console.WriteLine(arr.ToString());
        }
    }
}
