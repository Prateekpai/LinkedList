using System;

namespace LinkedListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();

            linkedList.Add(56);
            linkedList.Add(30);
            linkedList.Add(70);
            Console.WriteLine("\n...........................\n");
            linkedList.Display();
            Console.WriteLine("\n...........................\n");
            linkedList.InsertAtParticularPosition(3, 40);
            Console.WriteLine("\n...........................\n");
            linkedList.Display();
            Console.WriteLine("\n...........................\n");
        }
    }
}
