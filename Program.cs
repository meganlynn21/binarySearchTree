using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;
using static BinarySearchTrees.BST;
using static System.Net.Mime.MediaTypeNames;

namespace BinarySearchTrees
{
    public class Program
    {
        static void Main(string[] args)
        {
            Node root = null ;
            BST binarySearchTree = new BST(root);
            string prefix = "";
            binarySearchTree.Add(5);
            binarySearchTree.Add(2);
            binarySearchTree.Add(1);
            //binarySearchTree.Print(binarySearchTree.Root, prefix);
        }

    }
}