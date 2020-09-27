using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureCore.Sort
{
    public class MergeSort : BaseSort
    {
        public void Sort(int[] arr)
        {
            var length = 1;
            for ( length = 1; length < arr.Length; length = length * 2)
            {
                MergePass(arr, length);
            }
        }

        /// <summary>
        /// 一趟二路归并排序
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="length">二路归并排序的序列长度</param>
        private void MergePass(int[] arr, int length)
        {
            //序列的开始指针
            var i = 0;

            for (i = 0; i + length * 2 < arr.Length; i = i + length * 2)
            {
                Merge(arr, i, i + length - 1, i + length * 2 - 1);
            }

            //如果还剩下至少2个待合并的序列(i+length是第二个序列的开始位置)
            if (i + length  < arr.Length)
            {
                Merge(arr, i, i + length - 1, arr.Length - 1);
            }
        }


        private void Merge(int[] arr, int left, int mid, int right)
        {

            var length = (right - left + 1);
            var tmpArr = new int[length];

            //左区间的指针
            var i = left;

            //右区间的指针
            var j = mid + 1;

            //临时数组的指针
            var k = 0;

            while (i <= mid && j <= right)
            {
                if (arr[i] < arr[j])
                {
                    tmpArr[k] = arr[i];
                    i++;
                    k++;
                }
                else
                {
                    tmpArr[k] = arr[j];
                    j++;
                    k++;
                }

            }

            //把剩下的都放入临时数组中
            while (i <= mid)
            {
                tmpArr[k] = arr[i];
                i++;
            }
            while (j <= right)
            {
                tmpArr[k] = arr[j];
                j++;
            }

            //把排序好的元素放回到原序列
            var h = left;
            for (int g = 0; g < tmpArr.Length; g++)
            {
                arr[h] = tmpArr[g];
                h++;
            }

        }




    }
}
