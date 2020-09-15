using System;
using DataStructureCore.Model;

namespace DataStructureCore.BinaryTreeSamples
{
    public class BinaryTree
    {
        private int searchCount = 0;

        private TreeNode previousNode;
        private TreeNode resultNode;

        public TreeNode rootNode { get; set; }

        public void BuildTree(int[] values)
        {
            foreach (var value in values)
            {
                AddNode(value);
            }
        }

        public int SearchValue(TreeNode node, int value)
        {
            if (node == null)
                return -1;

            if (value == node.Value)
            {
                return this.searchCount;
            }
            else if (value < node.Value)
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
            if (node == null)
                return;

            Console.Write($"[{node.Value}] ");
            PreOrder(node.LeftNode);
            PreOrder(node.RightNode);
        }


        public void InOrder(TreeNode node)
        {
            if (node == null)
                return;
            InOrder(node.LeftNode);
            Console.Write($"[{node.Value}] ");
            InOrder(node.RightNode);
        }

        public void PostOrder(TreeNode node)
        {
            if (node == null)
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


        public void SearchNode(TreeNode node, int value)
        {
            if (node == null)
                return;

            if (value == node.Value)
            {
                resultNode = node;
            }
            else if (value < node.Value)
            {
                previousNode = node;
                SearchNode(node.LeftNode, value);
            }
            else
            {
                previousNode = node;
                SearchNode(node.RightNode, value);
            }
        }

        public void DeleteNode(int value)
        {
            this.SearchNode(this.rootNode, value);
            var deletedNode = resultNode;

            if (deletedNode == null)
                throw new ArgumentException("找不到该节点");


            //删除的节点如果是叶子节点直接删除就行
            if (deletedNode.LeftNode == null && deletedNode.RightNode == null)
            {
                if (previousNode.LeftNode.Value == deletedNode.Value)
                {
                    previousNode.LeftNode = null;
                }

                if (previousNode.RightNode.Value == deletedNode.Value)
                {
                    previousNode.RightNode = null;
                }
            }
            //删除节点如果仅有左子树或者右子树 就让前趋节点指向后趋节点
            else if (deletedNode.LeftNode == null || deletedNode.RightNode == null)
            {
                if (previousNode.LeftNode.Value == deletedNode.Value)
                {
                    previousNode.LeftNode = deletedNode.LeftNode;
                }

                if (previousNode.RightNode.Value == deletedNode.Value)
                {
                    previousNode.RightNode = deletedNode.RightNode;
                }
            }
            //删除节点既有左子树又有右子树时，1.找到删除节点的前趋节点(左子树的最右边节点) 2.替换删除节点的data域 3.把前趋节点的左子树接上 
            else
            {
                var currentNode = deletedNode.LeftNode;
                var preNode = deletedNode;
                while (currentNode.RightNode != null)
                {
                    preNode = currentNode;
                    currentNode = currentNode.RightNode;
                }

                deletedNode.Value = currentNode.Value;

                preNode.RightNode = currentNode.LeftNode;
            }
        }
    }
}