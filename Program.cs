using System;
using System.Collections.Generic;
namespace BinarySearchTrees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // The Dictionary class saved <key, value> pairs in an unsorted hashtable
            Dictionary<string, string> students = new Dictionary<string, string>();
            // Let's add students by id numbers
            students.Add("345", "Riley");
            students.Add("123", "Chris");
            // Prints in order they were added
            foreach (string id in students.Keys)
            {
                Console.WriteLine(id + ": " + students[id]);
            }

            // Copy the code above and create a new SortedDictionary students2 and add two items and print them out.
            SortedDictionary<string, string> students2 = new SortedDictionary<string, string>();
            students2.Add("31", "Meg");
            students2.Add("35", "Jason");
            // What order does it print them out in? Is it the same order as the Dictionary?
            foreach (string id in students2.Keys)
            {
                Console.WriteLine(id + ": " + students2[id]);
            }


        }
    }
}