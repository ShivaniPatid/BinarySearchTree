using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreeExample
{
    public class UCThreeBinarySearchTree<T> where T : IComparable<T>
    {
        public T NodeData { get; set; }
        public UCThreeBinarySearchTree<T> LeftTree { get; set; }
        public UCThreeBinarySearchTree<T> RightTree { get; set; }
        public UCThreeBinarySearchTree(T nodeData)
        {
            this.NodeData = nodeData;
            this.LeftTree = null;
            this.RightTree = null;
        }
        int leftCount = 0;
        int rightCount = 0;
        public void Insert(T item)
        {
            T currentNodeValue = this.NodeData;
            if ((currentNodeValue.CompareTo(item)) > 0)
            {
                if (this.LeftTree == null)
                    this.LeftTree = new UCThreeBinarySearchTree<T>(item);
                else
                    this.LeftTree.Insert(item);
            }
            else
            {
                if (this.RightTree == null)
                    this.RightTree = new UCThreeBinarySearchTree<T>(item);
                else
                    this.RightTree.Insert(item);
            }
        }

        public void Display()
        {
            if (this.LeftTree != null)
            {
                this.leftCount++;
                this.LeftTree.Display();
            }
            Console.WriteLine(this.NodeData.ToString());
            if (this.RightTree != null)
            {
                this.rightCount++;
                this.RightTree.Display();
            }
        }

        public void GetSize()
        {
            Console.WriteLine("Size" + " : " + (1 + this.leftCount + this.rightCount));
        }

        public bool IfExists(T element, UCThreeBinarySearchTree<T> node)
        {
            
            if (node == null)
            {
                Console.WriteLine("Element not found in Binary Search Tree");
                return false;
            }
            if (node.NodeData.Equals(element))
            {
                Console.WriteLine("Found the element in Binary Search Tree  " + node.NodeData);
                return true;
                
            }
            else
            {
                Console.WriteLine("Current element is {0} in binary Search Tree",node.NodeData);
            }
            if(element.CompareTo(node.NodeData) < 0)
            {
                IfExists(element, node.LeftTree); 
            }
            if(element.CompareTo(node.NodeData) > 0)
            {
                IfExists(element, node.RightTree);
            }
            return true;
        }
    }
}
