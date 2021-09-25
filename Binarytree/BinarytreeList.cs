using System;
using System.Collections.Generic;
using System.Text;

namespace Binarytree
{
    class BinarytreeList<Gtype>
    {
        public Node<Gtype> root;
        public BinarytreeList()
        {
            this.root = null;
        }
        public void Insert(int val)
        {
            this.root = InsertNode(this.root, val);
        }
        public Node<Gtype> InsertNode(Node<Gtype> root, int val)
        {
            if (root == null)
            {
                this.root = new Node<Gtype>(val);
                return this.root;
            }
            if (val < root.Data)
            {
                this.root.Pre = InsertNode(root.Pre, val);
                Console.WriteLine($"Data added to Pre : {val}");
            }
            if (val > root.Data)
            {
                this.root.Next = InsertNode(root.Next, val);
                Console.WriteLine($"Data added to Next : {val}");
            }
            return this.root;
        }
    }
}
