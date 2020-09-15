﻿using System;
using System.Collections;
using DataStructureCore.BinaryTreeSamples;
using DataStructureCore.StackSamples;

namespace DataStructureConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // var hanoiSamples = new HanoiSamples();
            // hanoiSamples.Hanoi(3,"塔1","塔2","塔3");

            // var mazeSamples=new  MazeSamples();
            // mazeSamples.PrintMaze();
            // mazeSamples.Move();
            // Console.WriteLine("------------------------------------------");
            // mazeSamples.PrintTrace();

            // var treeDataArr = new int[] {7, 4, 1, 5, 16, 8, 11, 12, 15, 9, 2};
            //
            // var binaryTree = new BinaryTree();
            // binaryTree.BuildTree(treeDataArr);
            // Console.WriteLine("前序遍历:");
            // binaryTree.PreOrder(binaryTree.rootNode);
            // Console.WriteLine();
            // Console.WriteLine("中序遍历:");
            // binaryTree.InOrder(binaryTree.rootNode);
            // Console.WriteLine();
            // Console.WriteLine("后序遍历:");
            // binaryTree.PostOrder(binaryTree.rootNode);
            // Console.WriteLine("-------搜索数据-------");
            // var searchCount = binaryTree.SearchValue(binaryTree.rootNode, 12);
            // Console.WriteLine($"搜索次数{searchCount}");
            
            
            // var treeDataArr = new int[] {7, 4, 1, 5, 16, 8, 11, 12, 15, 9, 2};
            // var inOrderThreadTree = new InOrderThreadBinaryTree();
            // inOrderThreadTree.BuildTree(treeDataArr);
            //
            // inOrderThreadTree.CreateInOrderThread(inOrderThreadTree.RootNode);
            //
            // inOrderThreadTree.InOrder(inOrderThreadTree.ThreadRooNode.LeftNode);
            
            
            var treeDataArr = new int[] {7, 4, 1, 5, 16, 8, 11, 12, 15,14,13, 9, 19,20};

            var binaryTree = new BinaryTree();
            binaryTree.BuildTree(treeDataArr);
           
            Console.WriteLine("中序遍历:");
            binaryTree.InOrder(binaryTree.rootNode);
            Console.WriteLine();
           
            // binaryTree.DeleteNode(1);
            // binaryTree.DeleteNode(19);
            binaryTree.DeleteNode(16);


        }
    }
}