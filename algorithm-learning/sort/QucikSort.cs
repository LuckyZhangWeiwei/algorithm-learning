namespace algorithm_learning.sort
{
    // https://www.bilibili.com/video/BV1at411T75o

    /*
     
     先换位置，再移动 被移动到的那边的left  ——》 再交换数据据 
     */
    public class QucikSort
    {
        public static void Sort(int[] array, int l, int r)
        {
            if (l > r) return;

            int left = l; 
            
            int right = r;

            int pivot = array[left];

            while (left < right)
            {
                while (left < right && array[right] > pivot)
                {
                    right--;
                }

                if (left < right)   // array[right] < pivot  该换位置了
                {
                    array[left] = array[right];
                }

                while (left < right && array[left] <= pivot)
                {
                    left++;
                }
                
                if (left < right)
                {
                    array[right] = array[left];
                }

                if (left >= right)
                {
                    array[left] = pivot;
                }
            }

            Sort(array, l, right - 1);  // 第一次 排序后，左边的

            Sort(array, right + 1, r);  // 第一次 排序后，右边的

        }
    }
}
