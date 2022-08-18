using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTrees
{
    //BST and Node class: Create a BST (Binary Search Tree) class and inside it,
    //a Node class that has an int data variable and two Node variables that point to its
    //left and right children.If you’re using C# or Java, write 3 constructors that have no
    //arguments, 1 data argument, and all 3 arguments. 

    public class BST
    {
        //Inside your BST class, add a Node root variable and a default constructor
        //that sets the root to null.
        public class Node
        {
            //Node left, right;
            Node left;
            Node right;
            Node root;
            int data;

            public Node(int data)
            {
                this.data = data;
            }
            public Node()
            {
                root = null;
                left = null;
                right = null;
            }

            public Node(int data, Node left)
            {

            }

            public void Add(int data)
            {
                if (root == null)
                    root = new Node(data);
                else if (data < root.data) // needs to be first node
                {
                    root = new Node(data, root);
                }
                else
                { // find place
                  // have a current and previous pointer
                    Node current = head, prev = head;
                    while (current != null)
                    {
                        if (data > current.data)
                        {
                            prev = current; // save current as previous
                            current = current.next; // move current forward
                        }
                        else // we found the place!
                        {   // 1. Make a new node pointing to the current node
                            Node n = new Node(data, current);
                            // 2. Make the previous node point to it
                            prev.next = n;
                            return; // done with add, return
                        }
                    }
                    // couldn't find the place and got to end of list so add to the end
                    prev.next = new Node(data, current);
                }
            }

            //    public void insert(int value)
            //    {
            //        if(value <= data)
            //        {
            //            if(left == null)
            //            {
            //                left = new Node(value);
            //            }
            //        else
            //            {
            //                left.insert(value);
            //            }
            //        }
            //        else
            //        {
            //            if(right == null)
            //            {
            //                right = new Node(value);
            //            }
            //            else
            //            {
            //                right.insert(value);
            //            }
            //        }
            //    }

            //    public Boolean contains(int value)
            //    {
            //        if(value == data)
            //        {
            //            return true;
            //        }
            //        else if(value < data)
            //        {
            //            if(left == null)
            //            {
            //                return false;
            //            }
            //            else
            //            {
            //                return left.contains(value);
            //            }
            //        }
            //        else
            //        {
            //            if(right == null)
            //            {
            //                return false;
            //            }
            //            else
            //            {
            //                return right.contains(value);
            //            }
            //        }
            //    }
            //}
        }
}
