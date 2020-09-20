using System;
using DataStructureCore.Model;

namespace DataStructureCore.Sort
{
    public class ShellSort
    {
        private int Factor
        {
            get { return 2; }
        }

        public void Sort(int[] arr)
        {
            var count = 1;
            var d = arr.Length / Factor;

            while (d > 0)
            {
                for (int i = d; i < arr.Length; i++)
                {
                    //j为相距d的元素索引(往前找)
                    var j = i - d;

                    //如果是反序就交换位置
                    if (j >= 0 && arr[j] > arr[i])
                    {
                        var temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }

                d = d / Factor;

                Console.Write($"第{count}次的排序结果:");
                ShowArr(arr);
                Console.WriteLine();
                count++;
            }
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