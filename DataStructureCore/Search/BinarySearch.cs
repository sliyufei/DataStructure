using System.Collections.Generic;

namespace DataStructureCore.Search
{
    public class BinarySearch
    {
        public int Search(int[] array, int low, int high, int value)
        {
            if (low > high)
            {
                return -1;
            }

            //取中间位置 
            int mid = (low + high) / 2;
            //如果中间位置的值等于要查找的值，则返回中间位置 
            if (array[mid] == value)
            {
                return mid;
            }
            //如果中间位置的值小于要查找的值，则对右子序列进行递归查找 
            else if (array[mid] < value)
            {
                return Search(array, mid + 1, high, value);
            }
            //如果中间位置的值大于要查找的值，则对左子序列进行递归查找 
            else
            {
                return Search(array, low, mid - 1, value);
            }
        }

        public int Search2(int[] array, int value)
        {
            var low = 0;
            var high = array.Length - 1;
           
            while (low < high)
            {
                int mid = (low + high) / 2;
                if (array[mid] == value)
                {
                    return mid;
                }
                else if (array[mid] < value)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }

            return -1;
        }
    }
}