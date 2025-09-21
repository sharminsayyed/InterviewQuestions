using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSTtraversal
{
    class Node
    {
        public int data;
        public Node left, right;
        public Node(int d)
        {
            data = d;
            left = right = null;
        }

    }
    class BST
    {
        // inorder = left ,root,right;
        public void inorder(Node root)
        {
            if (root == null) return;
            inorder(root.left);
            Console.Write(root.data+" ");
            inorder(root.right);
        }

        // preorder = root, left ,right
        public void preorder(Node root)
        {
            if (root == null) return;
            Console.Write(root.data + " ");
            preorder(root.left);
            preorder(root.right);
        }
        // postorder = left,right,root
        public void postorder(Node root)
        {
            if (root == null) return;
            postorder(root.left);
            postorder(root.right);
            Console.Write(root.data + " ");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Node root = new Node(1);
            root.left = new Node(2);
            root.right = new Node(3);
            root.left.left = new Node(4);
            root.left.right = new Node(5);

            BST tree = new BST();

            Console.Write("Inorder: ");
            tree.inorder(root);           
            Console.WriteLine();

            Console.Write("Preorder: ");
            tree.preorder(root);          
            Console.WriteLine();

            Console.Write("Postorder: ");
            tree.postorder(root);         
            Console.WriteLine();
        }
    }
}
