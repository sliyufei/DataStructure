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
            //构造初始堆
            BuildHeap(arr, arr.Length);
            Console.Write($"初始堆结果:");
            ShowArr(arr);
            Console.WriteLine();

            //找到最后一个元素和堆顶的元素进行交换
            for (int i = arr.Length - 1; i > 0; i--)
            {
                Swap(arr, 0, i);

                //从堆顶继续堆化
                Heapify(arr, i, 0);

                Console.Write($"第{arr.Length - i}次的排序结果:");
                ShowArr(arr);
                Console.WriteLine();
            }
        }


        private void BuildHeap(int[] arr, int n)
        {
            //完全二叉树的最后一个分支节点等于长度/2取下限
            //此处用索引比较方便 所以用的下面这个公式 var parent=（childNode-1)/2 取下限
            var lastNode = arr.Length - 1;
            var lastParent = (lastNode - 1) / 2;

            for (int i = lastParent; i >= 0; i--)
            {
                Heapify(arr, n, i);
            }
        }

        /// <summary>
        /// 堆化
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="n">二叉树的节点数</param>
        /// <param name="i">要堆化节点的索引</param>
        private void Heapify(int[] arr, int n, int i)
        {
            //节点的索引
            var left = 2 * i + 1;
            var right = 2 * i + 2;

            //只需要堆化分支节点，叶子节点不需要
            if (left > n - 1)
            {
                return;
            }

            var max = i;

            //如果左节点在序列内才排序
            //如果左节点比分支节点值大就把最大值索引赋值成左节点
            if (left < n && arr[left] > arr[i])
            {
                max = left;
            }

            //如果右节点比上一步比较完的值还大就把最大值索引赋值成右节点
            if (right < n && arr[right] > arr[max])
            {
                max = right;
            }

            //最大值不等于自己就交换
            if (max != i)
            {
                Swap(arr, max, i);

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