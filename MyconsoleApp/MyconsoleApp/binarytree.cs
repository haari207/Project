using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyconsoleApp
{

    class Node
    {
        public int Data;       // Value of the node
        public Node Left;      // Reference to left child
        public Node Right;     // Reference to right child

        public Node(int data)
        {
            Data = data;
            Left = null;
            Right = null;
        }
    }

    class BinaryTree
    {
        public Node Root;

        public BinaryTree()
        {
            Root = null;
        }

        // Insert a node into the tree
        public void Insert(int data)
        {
            Root = InsertRecursive(Root, data);
        }

        private Node InsertRecursive(Node root, int data)
        {
            if (root == null)
            {
                return new Node(data);
            }
            if (data < root.Data)
            {
                root.Left = InsertRecursive(root.Left, data);
            }
            else
            {
                root.Right = InsertRecursive(root.Right, data);
            }
            return root;
        }



        public void InOrderTraversal(Node root)
        {
            if (root != null)
            {
                InOrderTraversal(root.Left);
                Console.Write(root.Data + " ");
                InOrderTraversal(root.Right);
            }
        }


        public void PreOrderTraversal(Node root)
        {
            if (root != null)
            {
                Console.Write(root.Data + " ");
                PreOrderTraversal(root.Left);
                PreOrderTraversal(root.Right);
            }
        }

        public void PostOrderTraversal(Node root)
        {
            if (root != null)
            {
                PostOrderTraversal(root.Left);
                PostOrderTraversal(root.Right);
                Console.Write(root.Data + " ");
            }
        }






    }

}
