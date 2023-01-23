using System;

namespace BinarySearchTree
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            BinarySearchTree<int> binarySearch = new BinarySearchTree<int>(56);
            binarySearch.Insert(30);
            binarySearch.Insert(70);
            
            binarySearch.Display();
            bool result = binarySearch.IfExists(67, binarySearch);
            Console.WriteLine(result);
            Console.ReadKey();

        }
    }
}