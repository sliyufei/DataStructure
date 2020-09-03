using System;
namespace DataStructureCore.LinearTableSamples.LinkedList.CircularLinkedListSamples
{
    public class CircularLinkedList<T>
    {
        public Node<T> First { get; set; }

        public Node<T> Last { get; set; }

        public int Length { get; set; }

        public bool IsEmpty
        {
            get { return First == null; }
        }

        public Node<T> GetElement(int index)
        {
            var i = 0;
            var currentNode = First;
            while (currentNode != null && i < index)
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

        public void HeadInsert(Node<T> node)
        {
            if (IsEmpty)
            {
                this.First = node;
                this.Last = node;
                this.Last.Next = this.First;

            }
            else
            {
                //把头指针指向的节点放到插入节点之后，再把插入节点放到头指针后面
                node.Next = this.First;
                this.First = node;
                this.Last.Next = this.First;

            }
            this.Length++;
        }


        public void TailInsert(Node<T> node)
        {
            if (IsEmpty)
            {
                First = node;
                Last = node;
                this.Last.Next = this.First;

            }
            else
            {
                Last.Next = node;
                Last = node;
                this.Last.Next = this.First;
            }

            this.Length++;
        }

        public void Insert(Node<T> node, int index)
        {
            if (index == 0)
            {
                this.HeadInsert(node);
            }
            else if (index == this.Length - 1)
            {
                this.TailInsert(node);
            }
            else
            {
                var currentNode = this.GetElement(index);
                node.Next = currentNode.Next;
                currentNode.Next = node;

            }

            this.Length++;

        }



        public void Delete(int index)
        {
            var i = 0;
            var currentNode = First;
            Node<T> beforeNode = First;
            while (currentNode != null)
            {
                if (i == index)
                {

                    if (index == 0)
                    {
                        //移动头指针
                        First = currentNode.Next;
                        this.Last.Next = this.First;
                    }
                    else if (index == this.Length - 1)
                    {
                        //移动尾指针
                        beforeNode.Next = null;
                        Last = beforeNode;
                        this.Last.Next = this.First;
                    }
                    else
                    {
                        //指针域跳过当前节点
                        beforeNode.Next = currentNode.Next;
                    }

                    this.Length--;
                    return;
                }

                beforeNode = currentNode;
                currentNode = currentNode.Next;
                i++;
            }
        }


    }
}
