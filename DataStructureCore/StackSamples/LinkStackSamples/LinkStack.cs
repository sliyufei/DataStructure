using System;
namespace DataStructureCore.StackSamples.LinkStackSamples
{
    public class LinkStack<T>
    {
        private Node<T> front;

        public void Push(Node<T> node)
        {
            if (this.IsEmpty)
                this.front = node;
            else
            {
                node.Next = this.front;
                this.front = node;
            }

        }

        public bool Pop(out Node<T> node)
        {
            node = new Node<T>();
   
            if (this.IsEmpty)
                return false;

             node = this.front;
            this.front = this.front.Next;
            return true;

        }

        public bool IsEmpty { get { return this.front==null; } }
    }
}
