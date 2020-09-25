using System;
using DataStructureCore.Model;

namespace DataStructureCore.Sort
{
    public class InsertSort : BaseSort
    {
        public void Sort(int[] arr, SortDirection sortDirection)
        {
            //第一个元素一定在有序区
            for (int i = 1; i < arr.Length; i++)
            {
                //如果是反序就需要排序
                if (!Compare(arr[i - 1], arr[i], sortDirection))
                {
                    var temp = arr[i];

                    //一直互换位置到arr变成正序
                    for (int j = i - 1; j > -1 && Compare(temp, arr[j], sortDirection); j--)
                    {
                        //每次互换比较都是和temp比较，所以需要互换的时候直接把temp放到arr[j]即可
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }

                Console.Write($"第{i}次的排序结果:");
                ShowArr(arr);
                Console.WriteLine();
            }
        }

        private bool Compare(int x, int y, SortDirection sortDirection)
        {
            if (sortDirection == SortDirection.Asc)
            {
                return x < y;
            }
            else if (sortDirection == SortDirection.Desc)
            {
                return x > y;
            }

            return false;
        }

      
    }
}