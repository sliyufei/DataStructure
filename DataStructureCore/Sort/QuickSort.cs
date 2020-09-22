using System;

namespace DataStructureCore.Sort
{
    public class QuickSort
    {
        private int count;
        public void Sort(int[] arr, int left, int right)
        {
            //确定至少包含2个元素的序列， left=right 是一个元素
            if (left > right)
            {
                return;
            }
            
            count++;

            var i = left;
            var j = right;
            //取第一个元素为基准
            var point = arr[left];

            //指针相等的时候说明左右区间已经分好了
            while (i != j)
            {
                //j从右往左找，找到比基准值小的就和i交换
                while (j > i && arr[j] > point)
                {
                    j--;
                }

                arr[i] = arr[j];

                //i从左往右找，找到比基准值大的就和j交换
                while (i < j && arr[i] < point)
                {
                    i++;
                }

                arr[j] = arr[i];
            }

            //最后把基准值放到 i=j的位置
            arr[i] = point;
            
            Console.Write($"第{count}次的排序结果:");
            ShowArr(arr);
            Console.WriteLine();
            
            //排左子序列
            Sort(arr, left, i - 1);
            //排右子序列
            Sort(arr, i + 1, right);
        }

        private void ShowArr(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write($"[{item}] ");
            }
        }
    }
}