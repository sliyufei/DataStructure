using DataStructureCore.LinearTableSamples.LinkedList.SingleLinkedListSamples;
using DataStructureCore.LinearTableSamples.SingleLinkedListSamples.SingleLinkedList;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataStructureCore.Sort
{
    public class RadixSort : BaseSort
    {

        private Dictionary<int, SingleLinkedList<string>> distributionResult = new Dictionary<int, SingleLinkedList<string>>(10);

        private SingleLinkedList<string> collectResult = new SingleLinkedList<string>();

        private int radix;

        public void Sort(int[] arr)
        {
            //获取最大的Length
            InitData(arr);

            for (int i = radix; i > 0; i--)
            {
                //第一次不需要清空分配操作的数据
                if (i != radix)
                    distributionResult = new Dictionary<int, SingleLinkedList<string>>(10);

                //分配
                Distribution(i);

                //收集
                Collect();
            }

            var j = 0;
            var currentNode = collectResult.First;

            while (currentNode != null)
            {
                arr[j] = Convert.ToInt32(currentNode.Data);
                currentNode = currentNode.Next;
                j++;
            }

        }

        private void Collect()
        {
            //清空之前存的数据
            collectResult = new SingleLinkedList<string>();

            foreach (var keyValue in distributionResult.OrderBy(o => o.Key))
            {
                collectResult.TailInsert(keyValue.Value);

            }


        }

        private void Distribution(int position)
        {
            var currentNode = collectResult.First;

            while (currentNode != null)
            {
                var positionValue = GetPositionValue(currentNode.Data, position);

                if (!distributionResult.ContainsKey(positionValue))
                {
                    distributionResult[positionValue]= new SingleLinkedList<string>();
                }

                var linkedList = distributionResult[positionValue];

                linkedList.TailInsert(new Node<string>(currentNode.Data));

                currentNode = currentNode.Next;
            }
        }
        
        /// <summary>
        /// 获取指定位置上的值
        /// </summary>
        /// <param name="value"></param>
        /// <param name="position"></param>
        /// <returns></returns>
        private int GetPositionValue(string value, int position)
        {
          
            var positionValue = Convert.ToInt32(Char.ConvertFromUtf32(value[position - 1]));

            return positionValue;
        }

        private void InitData(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                var tmp = arr[i].ToString();

                if (radix < tmp.Length)
                    radix = tmp.Length;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                var tmp = arr[i].ToString().PadLeft(radix, '0'); ;
              
                collectResult.TailInsert(new Node<string>(tmp));

                if (radix < tmp.Length)
                    radix = tmp.Length;
            }

        }

     
    }
}
