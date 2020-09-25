using System;

namespace DataStructureCore.Sort
{
    public class SelectSort : BaseSort
    {
        public void Sort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                var k = GetMin(arr, i);
                if (k!=i)
                {
                    Swap(arr, k, i);
                }
                
                Console.Write($"第{i+1}次的排序结果:");
                ShowArr(arr);
                Console.WriteLine();
            }
        }

        private int GetMin(int[] arr, int left)
        {
            var k = left;

            for (int i = left+1; i < arr.Length; i++)
            {
                if (arr[i] < arr[k])
                {
                    k = i;
                }
            }


            return k;
        }
        
     
        
    }
}