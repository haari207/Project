using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyconsoleApp
{
    internal class linkedlist
    {


            public void display()
            {

                // Creating a LinkedList of strings
                LinkedList<string> linkedList = new LinkedList<string>();

                // Adding elements to the LinkedList
                linkedList.AddLast("First");
                linkedList.AddLast("Second");
                linkedList.AddLast("Second");

                // Adding a node at the beginning
                linkedList.AddFirst("Zero");
                LinkedListNode<string> secondNode = linkedList.Find("Second");

                if (secondNode != null)
                {
                    // Adding a node after "Second"
                    linkedList.AddAfter(secondNode, "InsertedAfterSecond");

                    // Adding a node before "Second"
                    linkedList.AddBefore(secondNode, "InsertedBeforeSecond");
                }




                // Displaying LinkedList elements
                Console.WriteLine("LinkedList elements:");
                foreach (var item in linkedList)
                {
                    Console.WriteLine(item);
                }

                // Removing an element
                linkedList.Remove("Second");

                Console.WriteLine("\nAfter Removing 'Second':");
                foreach (var item in linkedList)
                {
                    Console.WriteLine(item);
                }
            }
        }

    }

