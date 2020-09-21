using System;

namespace DataStructureCore.Sort
{
    public class BubbleSort
    {
        public void Sort(int[] arr)
        {
          
            for (int i = 0; i < arr.Length - 1; i++)
            {
                var isExchange = false;
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j]>arr[j+1])
                    {
                        var temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;

                        isExchange = true;
                    }
                }
                
                //如果没有发生交换就说明已经排好了
                if (!isExchange)
                    return;
                
                Console.Write($"第{i+1}次的排序结果:");
                ShowArr(arr);
                Console.WriteLine();

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