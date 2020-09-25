using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureCore.Sort
{
    public class BaseSort
    {
        protected void Swap(int[] arr, int x, int y)
        {
            var temp = arr[x];
            arr[x] = arr[y];
            arr[y] = temp;
        }

        protected void ShowArr(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write($"[{item}] ");
            }
        }
    }
}
