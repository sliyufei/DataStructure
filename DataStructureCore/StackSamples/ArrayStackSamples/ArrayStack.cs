using System;
namespace DataStructureCore.StackSamples.ArrayStackSamples
{
    public class ArrayStack<T>
    {
        private int top;

        private T[] stack;

        public ArrayStack(int size)
        {
            stack = new T[size];
            this.top = -1;
        }

        public bool Push(T data)
        {
            if (top >= stack.Length - 1)
                return false;

            top++;
            stack[top] = data;

            return true;
        }

        public bool Pop(out T data)
        {
            data = default(T);

            if (this.IsEmpty)
                return false;

            data = stack[top];
            top--;

            return true;
        }

        public bool IsEmpty { get { return top <= -1; } }


       
    }
}
