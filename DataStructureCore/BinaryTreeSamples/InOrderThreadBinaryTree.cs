using System;
using DataStructureCore.Model;

namespace DataStructureCore.BinaryTreeSamples
{
    public class InOrderThreadBinaryTree
    {
        /// <summary>
        /// 树根节点
        /// </summary>
        public ThreadTreeNode RootNode { get; set; }


        /// <summary>
        /// 线索根节点
        /// </summary>
        public ThreadTreeNode ThreadRooNode { get; set; }

        private ThreadTreeNode previousNode;

        public void CreateInOrderThread(ThreadTreeNode treeNode)
        {
            if (ThreadRooNode == null)
            {
                this.ThreadRooNode = new ThreadTreeNode(Int32.MinValue);
                this.ThreadRooNode.LeftNode = treeNode;
                this.ThreadRooNode.RightNode = treeNode;
                this.ThreadRooNode.RightTag = 1;
            }

            previousNode = this.ThreadRooNode;
            Thread(treeNode);
            
            //最后一个节点指向头节点
            previousNode.RightNode = this.ThreadRooNode;
            previousNode.RightTag = 1;
            this.ThreadRooNode.RightNode = previousNode;
        }

        /// <summary>
        /// previousNode 指向的是上一个遍历的节点
        /// </summary>
        /// <param name="currentNode"></param>
        private void Thread(ThreadTreeNode currentNode)
        {
            if (currentNode == null)
                return;

            Thread(currentNode.LeftNode);

            if (currentNode.LeftNode == null)
            {
                currentNode.LeftNode = previousNode;
                currentNode.LeftTag = 1;
            }

            if (previousNode.RightNode == null)
            {
                previousNode.RightNode = currentNode;
                previousNode.RightTag = 1;
            }

            previousNode = currentNode;

            Thread(currentNode.RightNode);
        }

        public void InOrder(ThreadTreeNode node)
        {
            var currentNode = node;

            while (currentNode != this.ThreadRooNode)
            {
                //找到左边的开始节点
                while (currentNode.LeftTag == 0)
                {
                    currentNode = currentNode.LeftNode;
                }

                Console.Write($"[{currentNode.Value}] ");

                while (currentNode.RightTag == 1 && currentNode.RightNode != this.ThreadRooNode)
                {
                    currentNode = currentNode.RightNode;
                    Console.Write($"[{currentNode.Value}] ");
                }

                currentNode = currentNode.RightNode;
            }
        }

        public void BuildTree(int[] values)
        {
            foreach (var value in values)
            {
                AddNode(value);
            }
        }

        private void AddNode(int value)
        {
            if (RootNode == null)
            {
                RootNode = new ThreadTreeNode(value);
                return;
            }

            var currentNode = RootNode;

            while (true)
            {
                //插入节点的值小于当前节点就往左子树找
                if (value < currentNode.Value)
                {
                    if (currentNode.LeftNode == null)
                    {
                        //一直找到要比插入节点小的节点(比较值)
                        currentNode.LeftNode = new ThreadTreeNode(value);
                        return;
                    }

                    //一直往左找
                    currentNode = currentNode.LeftNode;
                }
                else
                {
                    if (currentNode.RightNode == null)
                    {
                        //一直找到要比插入节点大的节点(比较值)
                        currentNode.RightNode = new ThreadTreeNode(value);
                        return;
                    }

                    //一直往右找
                    currentNode = currentNode.RightNode;
                }
            }
        }
    }
}