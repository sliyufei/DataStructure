﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureCore.QueueSamples.ArrayQueueSamples
{
    public class ArrayQueue<T>
    {
        //出队
        private int front;

        //入队
        private int rear;

        private int size;

        private T[] datas;

        public ArrayQueue(int size)
        {
            this.front = 0;
            this.rear = 0;
            this.size = size;
            this.datas = new T[size];
        }


        public bool IsEmpty { get { return front == rear; } }

        public bool IsFull { get { return (rear + 1) % size == front; } }


        public bool Enqueue(T data)
        {
            if (IsFull)
                return false;

            datas[rear] = data;

            //队尾+1取余得到下一个元素放置的索引
            rear = (rear + 1) % size;
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
            return true;
        }

    }
}
