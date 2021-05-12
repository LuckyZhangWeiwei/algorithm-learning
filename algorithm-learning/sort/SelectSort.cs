using System;

namespace algorithm_learning.sort
{
     /*
     *外层循环依次拿到一个位置，然后从这个位置的后一个一直到数组最后比较，如果后面元素比外层循环拿到的位置的值小 则交换数值
     */
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
