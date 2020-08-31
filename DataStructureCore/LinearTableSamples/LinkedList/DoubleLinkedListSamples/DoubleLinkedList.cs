using System;
namespace DataStructureCore.LinearTableSamples.LinkedList.DoubleLinkedListSamples
{
    public class DoubleLinkedList<T>
    {
        public Node<T> First { get; set; }

        public Node<T> Last { get; set; }

        public int Length { get; set; }

        public bool IsEmpty
        {
            get { return First == null; }
        }

        public void Print()
        {
         

        }

        public Node<T> GetElement(int index)
        {
           

        }

        public int GetIndex(Node<T> node)
        {
            
        }


        /// <summary>
        /// 头插法
        /// </summary>
        /// <param name="node"></param>
        public void HeadInsert(Node<T> node)
        {
           
        }

        /// <summary>
        /// 尾插法
        /// </summary>
        /// <param name="node"></param>
        public void TailInsert(Node<T> node)
        {
           
        }


        public void Delete(int index)
        {
       
        }

        public void Reverse()
        {
           
        }

        private Node<T> Clone(Node<T> node)
        {
            return new Node<T>(node.Data);
        }
    }
}
