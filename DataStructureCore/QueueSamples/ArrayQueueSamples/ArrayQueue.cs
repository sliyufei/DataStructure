using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureCore.QueueSamples.ArrayQueueSamples
{
    public class ArrayQueue<T>
    {

        private int front;

        private int size;

        private T[] datas;

        public ArrayQueue(int size)
        {
            this.size = size;
            this.datas = new T[size];
        }


        public bool IsEmpty { get { return datas.Length == 0; } }

        public bool IsFull { get { return datas.Length == size; } }


        public bool Enqueue(T data)
        {
            if (IsFull)
                return false;

            //先求队尾
            var rear = (front + datas.Length) % size;

            //队尾+1取余得到元素放置的索引
            rear = (rear + 1) % size;

            datas[rear] = data;

            return true;
        }


        public T Dequeue()
        {

            return default(T);
        }

    }
}
