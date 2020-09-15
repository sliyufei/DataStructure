using System;
using DataStructureCore.Model;

namespace DataStructureCore.BinaryTreeSamples
{
    public class BinaryTree
    {
        private int searchCount = 0;
        
        public TreeNode rootNode { get; set; }
        public void BuildTree(int[] values)
        {
            foreach (var value in values)
            {
                AddNode(value);
            }
        }

        public int SearchValue(TreeNode node,int value)
        {
            if (node==null)
                return -1;

            if (value==node.Value)
            {
                return this.searchCount;
            }
            else if (value<node.Value)
            {
                this.searchCount++;
                SearchValue(node.LeftNode, value);
            }
            else
            {
                this.searchCount++;
                SearchValue(node.RightNode, value);
            }

            return this.searchCount;
        }

        public void PreOrder(TreeNode node)
        {
            if (node==null)
                return;
            
            Console.Write($"[{node.Value}] ");
            PreOrder(node.LeftNode);
            PreOrder(node.RightNode);
        }
        

        public void InOrder(TreeNode node)
        {
            if (node==null)
               return;
            InOrder(node.LeftNode);
            Console.Write($"[{node.Value}] ");
            InOrder(node.RightNode);
        }
        
        public void PostOrder(TreeNode node)
        {
            if (node==null)
                return;
            
            PostOrder(node.LeftNode);
            PostOrder(node.RightNode);
            Console.Write($"[{node.Value}] ");
        }
        


        private void AddNode(int value)
        {
            if (rootNode == null)
            {
                rootNode = new TreeNode(value);
                return;
            }

            var currentNode = rootNode;

            while (true)
            {
                //插入节点的值小于当前节点就往左子树找
                if (value < currentNode.Value)
                {
                    if (currentNode.LeftNode == null)
                    {
                        //一直找到要比插入节点小的节点(比较值)
                        currentNode.LeftNode = new TreeNode(value);
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
                        currentNode.RightNode = new TreeNode(value);
                        return;
                    }

                    //一直往右找
                    currentNode = currentNode.RightNode;
                }
            }
        }
    }
}