using System;

namespace BinarySearchTrees
{
    public class Insert
    {
        public void InsertIntoTree()
        {
            BST binarySearchTree = new BST();
            binarySearchTree.Add(5);
            binarySearchTree.Add(2);
            binarySearchTree.Add(1);
            binarySearchTree.Add(7);
            binarySearchTree.Add(8);
            binarySearchTree.Print(binarySearchTree.Root, "");
        }
    }
}
