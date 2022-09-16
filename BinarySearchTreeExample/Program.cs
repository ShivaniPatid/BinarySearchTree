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
                default:
                    Console.WriteLine("Choose a appropriate option");
                    break;
            }




            Console.ReadLine();
        }

    }
}
