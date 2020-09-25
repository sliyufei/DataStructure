using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureCore.Sort
{
    public class MergeSort : BaseSort
    {
        public void Sort(int[] arr)
        {

        }

        private void Merge(int[] arr, int left, int mid, int right)
        {
            //
            var length = (mid - left + 1) + (right - (mid + 1) + 1);
            var tmpArr = new int[length];

        }




    }
}
