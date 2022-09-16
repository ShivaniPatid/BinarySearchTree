using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreeExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a option");
            Console.WriteLine("1. UC1 - Create a Binary Tree");
            Console.WriteLine("2. UC2 - Create a Binary Tree");
            Console.WriteLine("3. UC3 - Search the element in binary tree");
            int option=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            switch (option)
            {
                case 1:
                    UCOneBinarySearchTree<int> binarySearchTree1 = new UCOneBinarySearchTree<int>(56);
                    binarySearchTree1.Insert(30);
                    binarySearchTree1.Insert(70);
                    binarySearchTree1.Display();
                    break;
                case 2:
                    UCTwoBinarySearchTree<int> binarySearchTree2 = new UCTwoBinarySearchTree<int>(56);
                    binarySearchTree2.Insert(30);
                    binarySearchTree2.Insert(70);
                    binarySearchTree2.Insert(22);
                    binarySearchTree2.Insert(40);
                    binarySearchTree2.Insert(60);
                    binarySearchTree2.Insert(95);
                    binarySearchTree2.Insert(11);
                    binarySearchTree2.Insert(65);
                    binarySearchTree2.Insert(3);
                    binarySearchTree2.Insert(16);
                    binarySearchTree2.Insert(63);
                    binarySearchTree2.Insert(67);
                    binarySearchTree2.Display();
                    binarySearchTree2.GetSize();
                    break;
                case 3:
                    UCThreeBinarySearchTree<int> binarySearchTree3 = new UCThreeBinarySearchTree<int>(56);
                    binarySearchTree3.Insert(30);
                    binarySearchTree3.Insert(70);
                    binarySearchTree3.Insert(22);
                    binarySearchTree3.Insert(40);
                    binarySearchTree3.Insert(60);
                    binarySearchTree3.Insert(95);
                    binarySearchTree3.Insert(11);
                    binarySearchTree3.Insert(65);
                    binarySearchTree3.Insert(3);
                    binarySearchTree3.Insert(16);
                    binarySearchTree3.Insert(63);
                    binarySearchTree3.Insert(67);
                    binarySearchTree3.Display();
                    binarySearchTree3.GetSize();
                    bool result = binarySearchTree3.IfExists(63, binarySearchTree3);
                    break;
                default:
                    Console.WriteLine("Choose a appropriate option");
                    break;
            }




            Console.ReadLine();
        }

    }
}
