using System;

namespace LinkedListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();


            linkedList.Add(70);
            linkedList.Display();
            Console.WriteLine("\n.....................\n");
            linkedList.InsertAtParticularPosition(2, 30);
            linkedList.InsertAtParticularPosition(3, 56);
            Console.WriteLine("\n.....................\n");
            linkedList.Display();
        }
    }
}
