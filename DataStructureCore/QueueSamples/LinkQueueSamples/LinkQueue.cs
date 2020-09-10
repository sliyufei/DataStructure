using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureCore.QueueSamples.LinkQueueSamples
{
    public class LinkQueue<T>
    {
        private Node<T> front;

        private Node<T> rear;


        public bool IsEmpty { get { return front == null; } }


        public void Enqueue(Node<T> node)
        {
            if (IsEmpty)
            {
                this.front = node;
                this.rear = node;
            }
            else
            {
                this.rear.Next = node;
                this.rear = node;
            }

        }


        public Node<T> Dequeue()
        {
            if (!IsEmpty)
            {
                var node = this.front;
                this.front = node.Next;

                if (this.front == null)
                    this.rear = null;

                return node;

            }

            return null;
        }




    }
}
