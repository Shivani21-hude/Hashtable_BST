using Hashtable;
using System;

namespace HashtableDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hash table demo"); //() []
            MyMapNode<string, string> hash = new MyMapNode<string, string>(8);
            //hash.Add("0", "To");
            //hash.Add("1", "be");
            //hash.Add("2", "or");
            //hash.Add("3", "not");
            //hash.Add("4", "to");
            //hash.Add("5", "be");
            //string hash5 = hash.Get("5");
            //Console.WriteLine("5th index value: " + hash5);
            //string hash2 = hash.Get("2");
            //Console.WriteLine("2th index value: " + hash2);

            hash.Add("a", "BridgeLabz");
            hash.Add("b", "is");
            hash.Add("c", "a");
            hash.Add("d", "platform");
            hash.Add("e", "for");
            hash.Add("f", "to");
            hash.Add("g", "learn");
            hash.Add("h", "programming");
            hash.Add("i", "skills.");
           
            string hash0 = hash.Get("a");
            Console.WriteLine("0th index value: " + hash0);
            string hash7 = hash.Get("h");
            Console.WriteLine("7th index value: " + hash7);
        }
    }
}