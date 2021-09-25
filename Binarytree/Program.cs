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
            binarytreeList.Insert(22);
            binarytreeList.Insert(40);
            binarytreeList.Insert(11);
            binarytreeList.Insert(16);
            binarytreeList.Insert(3);

            binarytreeList.Insert(70);
            binarytreeList.Insert(60);
            binarytreeList.Insert(95);
            binarytreeList.Insert(65);
            binarytreeList.Insert(63);
            binarytreeList.Insert(67);
            binarytreeList.Find(63);

        }
    }
}
