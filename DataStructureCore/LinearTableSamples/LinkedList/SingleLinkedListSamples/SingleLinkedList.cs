using System;
using DataStructureCore.LinearTableSamples.LinkedList.SingleLinkedListSamples;

namespace DataStructureCore.LinearTableSamples.SingleLinkedListSamples.SingleLinkedList
{
    public class SingleLinkedList<T>
    {
        private Node<T> first;

        private Node<T> last;

        public bool IsEmpty
        {
            get{return first==null;}
        }

        public void Print()
        {
            var currentNode=first;
            
            while (currentNode!=null)
            {
                Console.WriteLine($"node:{Newtonsoft.Json.JsonConvert.SerializeObject(currentNode)}");
                currentNode = currentNode.Next;
            }

        }

        /// <summary>
        /// 头插法
        /// </summary>
        /// <param name="node"></param>
        public void HeadInsert(Node<T> node)
        {
            if (IsEmpty)
            {
                first = node;
                last = node;

            }
            else
            {
                //把头指针的下一个节点放到插入节点之后，再把插入节点放到头指针后面
                node.Next = first.Next;
                first.Next = node;

            }
        }

        /// <summary>
        /// 尾插法
        /// </summary>
        /// <param name="node"></param>
        public void TailInsert(Node<T> node)
        {
            if (IsEmpty)
            {
                first = node;
                last = node;

            }
            else
            {
                last.Next = node;
                last = node;
            }
        }
    }
}
