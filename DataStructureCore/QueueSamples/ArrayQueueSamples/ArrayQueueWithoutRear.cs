using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureCore.QueueSamples.ArrayQueueSamples
{
    public class ArrayQueueWithoutRear<T>
    {

        private int front;

        private int size;

        private T[] datas;

        private int length;

        public ArrayQueueWithoutRear(int size)
        {
            this.front = 0;
            this.size = size;
            this.datas = new T[size];
            this.length = 0;
        }


        private int Rear { get { return (front + length) % size; } }

        public bool IsEmpty { get { return length == 0; } }

        public bool IsFull { get { return length == size; } }


        public bool Enqueue(T data)
        {
            if (IsFull)
                return false;

            datas[Rear] = data;

            this.length++;
            return true;
        }


        public bool Dequeue(out T data)
        {
            data = default(T);

            if (IsEmpty)
                return false;

            data = datas[front];
            datas[front] = default(T);

            front = (front + 1) % size;
            this.length--;
            return true;
        }
    }
}
