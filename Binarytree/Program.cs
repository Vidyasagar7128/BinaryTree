using System;

namespace Binarytree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Binary Tree!");
            BinarytreeList<int> binarytreeList = new BinarytreeList<int>();
            binarytreeList.Insert(56);
            binarytreeList.Insert(30);
            binarytreeList.Insert(70);

        }
    }
}
