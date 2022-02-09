using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreeProb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello welcome to Binary search tree problem ");
            ViewBST();
            Console.ReadLine();
        }
        /// <summary>
        /// Method to Initialize Nodes.
        /// </summary>
        public static void ViewBST()
        {
            MyBinaryTree<int> tree = new MyBinaryTree<int>();
            tree.CreateNode(56);
            tree.CreateNode(30);
            tree.CreateNode(70);
            Console.WriteLine("Display Nodes present in Binary Search Tree");
            tree.Display();
        }
    }
                
}
