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
            var currentNode = First;

            while (currentNode != Last)
            {
                currentNode = currentNode.Next;
            }

        }

        public Node<T> GetElement(int index)
        {
            var i = 0;
            var currentNode = First;
            while (currentNode != Last && i < index)
            {
                currentNode = currentNode.Next;
                i++;
            }

            if (i == index)
                return currentNode;
            else
                return null;

        }

        public int GetIndex(Node<T> node)
        {
            var index = 0;
            var currentNode = First;
            while (currentNode != null && !currentNode.Equals(node))
            {
                currentNode = currentNode.Next;
                index++;
            }

            if (currentNode.Equals(node))
                return index;
            else
                return -1;

        }


        /// <summary>
        /// 头插法
        /// </summary>
        /// <param name="node"></param>
        public void HeadInsert(Node<T> node)
        {
            if (IsEmpty)
            {
                this.First = node;
                this.Last = node;

            }
            else
            {
                //新插入节点的next指向原链表的第一个节点，原链表的第一个节点的previous指向插入节点
                node.Next = this.First;
                this.First.Previous = node;
                this.First = node;

            }
            this.Length++;

        }

        /// <summary>
        /// 尾插法
        /// </summary>
        /// <param name="node"></param>
        public void TailInsert(Node<T> node)
        {
            if (IsEmpty)
            {
                First = node;
                Last = node;

            }
            else
            {
                Last.Next = node;
                node.Previous = this.Last;
                Last = node;
            }
            this.Length++;

        }

        public void Insert(Node<T> node,int index)
        {
            if (index == 0)
            {
                this.HeadInsert(node);
            }
            else if (index==this.Length-1)
            {
                this.TailInsert(node);
            }
            else
            {
                //建议画图，文字不好描述
                var currentNode = this.GetElement(index);

                //插入节点前趋节点指向当前节点，插入节点的后趋节点指向当前节点的下一个节点
                node.Next = currentNode.Next;
                node.Previous = currentNode;

                //把当前节点的下一个节点的前趋节点指向插入节点
                currentNode.Next.Previous = node;

                //把当前节点的后趋节点指向插入节点
                currentNode.Next = node;

            }

            this.Length++;

        }



        public void Delete(int index)
        {

            if (index==0)
            {
                this.First.Next.Previous = null;
                this.First = this.First.Next;
            }
            else if (index == this.Length-1)
            {
                this.Last.Previous.Next = null;
                this.Last = this.Last.Previous;
            }
            else
            {
                var deleteNode = this.GetElement(index);

                deleteNode.Previous.Next = deleteNode.Next;
                deleteNode.Next.Previous = deleteNode.Previous;
            }

        }
    }
}
