using System;

namespace DataStructureCore.Sort
{
    /// <summary>
    /// 把数组看成一颗完全二叉树，再使用堆这种数据结构，摆成大根堆
    /// </summary>
    public class HeapSort
    {
        public void Sort(int[] arr)
        {
            //完全二叉树的最后一个分支节点等于长度/2取下限
            var lastParent = arr.Length / 2;

            for (int i = lastParent; i > 0; i--)
            {
                //Heapify(arr,,i);
            }
        }

        /// <summary>
        /// 堆化
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="n">二叉树的节点数</param>
        /// <param name="i">堆化节点的序号</param>
        private void Heapify(int[] arr, int n, int i)
        {
            //节点的序号
            var left = 2 * i;
            var right = 2 * i + 1;

            //只需要堆化分支节点，叶子节点不需要
            if (left > n && right > n)
            {
                return;
            }

            var max = i;

            if (arr[left - 1] > arr[i - 1])
            {
                max = left;
            }
            else if (arr[right - 1] > arr[i - 1])
            {
                max = right;
            }

            //最大值不等于自己就交换
            if (max != i)
            {
                Swap(arr, max - 1, i - 1);

                //需要把从堆化的节点往下的节点全部重新堆化(因为交换完值，可能存在子节点不满足堆的定义)
                Heapify(arr, n, max);
            }
        }

        private void Swap(int[] arr, int x, int y)
        {
            var temp = arr[x];
            arr[x] = arr[y];
            arr[y] = temp;
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