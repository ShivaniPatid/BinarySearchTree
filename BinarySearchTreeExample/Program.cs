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
            Console.WriteLine("1. UC1 - Create a Binary Search Tree");
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
                default:
                    Console.WriteLine("Choose a appropriate option");
                    break;
            }




            Console.ReadLine();
        }

    }
}
