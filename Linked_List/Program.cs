using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nWelcome to Linked list section");
            Console.WriteLine("________________________________\n");
            LinkedList<int> list = new LinkedList<int>(); // creating a object of in built LinkedList generic class 
            list.AddFirst(56); // Calling method of Linked List generic class to add 56 at first
            list.AddLast(30); // Calling method of Linked List generic class to add 30 at last
            list.AddLast(70); // Calling method of Linked List generic class to add 70 at last
            foreach (int element in list)
            {
                Console.WriteLine("Linked_List Elements Are " + element); // Printing all the element of linked list
            }
            Console.ReadLine();
        }
    }
}
