﻿using System;
using System.Reflection;
using DataStructureCore.LinearTableSamples.LinkedList.SingleLinkedListSamples;

namespace DataStructureCore.LinearTableSamples.SingleLinkedListSamples.SingleLinkedList
{
    public class SingleLinkedList<T>
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

            while (currentNode != null)
            {
                Console.WriteLine($"node:{Newtonsoft.Json.JsonConvert.SerializeObject(currentNode)}");
                currentNode = currentNode.Next;
            }

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
                //把头指针指向的节点放到插入节点之后，再把插入节点放到头指针后面
                node.Next = this.First;
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
                Last = node;
            }
            this.Length++;
        }

        public void TailInsert(SingleLinkedList<T> linkList)
        {
            if (IsEmpty)
            {
                First = linkList.First;
                Last = linkList.Last;

            }
            else
            {
                Last.Next = linkList.First;
                Last = linkList.Last;
            }
            this.Length += linkList.Length;
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
                    }
                    else if (index == this.Length - 1)
                    {
                        //移动尾指针
                        beforeNode.Next = null;
                        Last = beforeNode;
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

        public void Reverse()
        {
            var tmpList = new SingleLinkedList<T>();
            var currentNode = First;

            while (currentNode != null)
            {
                var node = Clone(currentNode);
                node.Next = null;
                tmpList.HeadInsert(node);

                currentNode = currentNode.Next;
            }
            First = tmpList.First;
            Last = tmpList.Last;
        }

        private Node<T> Clone(Node<T> node)
        {
            return new Node<T>(node.Data); 
        }

    }
}
