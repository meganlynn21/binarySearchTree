﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Numerics;
using System.Text;
using static BinarySearchTrees.BST;
using static System.Net.Mime.MediaTypeNames;

namespace BinarySearchTrees
{
    //BST and Node class: Create a BST (Binary Search Tree) class and inside it,
    //a Node class that has an int data variable and two Node variables that point to its
    //left and right children.If you’re using C# or Java, write 3 constructors that have no
    //arguments, 1 data argument, and all 3 arguments. 

    public class BST
    {
        public class Node
        {
            public int Data { get; set; }
            public Node Left { get; set; }
            public Node Right { get; set; }


            // constructor with 1 data param
            public Node(int data)
            {
                this.Data = data;
            }
            // constructor with no params
            public Node()
            {
                this.Data = 0;
                this.Left = null;
                this.Right = null;
            }

            // constructor with 3 params
            public Node(Node left, Node right, int data)
            {
                this.Left = left;
                this.Right = right;
                this.Data = data;
            }
        }

        //Inside your BST class, add a Node root variable and a default constructor
        //that sets the root to null.
        public Node Root { get; set; }
        public BST(Node root)
        {
            this.Root = root;
        }

        public void Add(int value)
        {
            // If the root is null, set the root to a new BST node with the number
            // in it using the right constructor.
            if (Root == null)
                Root = new Node(value);
            //else if (value < Root.Data) // needs to be first node
            //{
            //    Root = new Node(value);
            //}
            //Otherwise, set current to the root and start a loop while current does not equal null to find the correct place to add.In the loop:
            else
            {
                Root = new Node(value);
                Node current = Root;
                while (current != null)
                {
                    //If the number is less than the current data, 
                    if (value < current.Data)
                    {
                        //If current’s left is null, add the number there, by making a new node and setting current’s left to it and return.
                        //Move current to current’s left
                        if (current.Left == null)
                        {
                            current.Left = new Node(value);
                            Console.WriteLine(current = current.Left);
                        }
                        //If the number is greater than the current data,
                        if (value > current.Data)
                        {
                            if (current.Right == null)
                            {
                                //If current’s right is null, add the number there,   
                                //By making a new node and setting current’s right to it and return.
                                current.Right = new Node(value);
                                //Move current to current’s right
                                current = current.Right;
                            }
                        }
                    }
                }

            }
        }

        //Test your functions by calling them with data like add(5), add(3), add(7)
        //    and then printing out the tree.If you’re using Visual C#, have 
        //a textbox to add numbers to the binary search tree and buttons to add, find, 
        //and clear the tree (this can just set the root to null). 
        //You can use the following C# recursive print function in your BST class
        //that prints to the console that I stole from stackoverflow 
        //(call with:  tree.print(tree.root, ""); if tree is your BST object).

        public void Print(Node root, string prefix)
        {
            if (root == null)
            {
                Console.WriteLine(prefix + "+- <null>");
                return;
            }
            Console.WriteLine(prefix + "+- " + root.Data);
            Print(root.Left, prefix + "|  ");
            Print(root.Right, prefix + "|  ");
            Console.ReadLine();
        }
    }
}
