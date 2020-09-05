using System;
namespace DataStructureCore.StackSamples.LinkStackSamples
{
    public class Node<T>
    {
        public T Data { get; set; }

        public Node<T> Next { get; set; }

        public Node()
        {

        }

        public Node(T data)
        {
            Data = data;
        }
    }
}
