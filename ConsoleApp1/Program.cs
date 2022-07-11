using System;

namespace DataStructuresTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            LinkedList numList = new LinkedList();
            Stack stackList = new Stack();
            Queue queueList = new Queue();
           
            queueList.Enqueue(1);
            queueList.Enqueue(2);
            queueList.Enqueue(3);
            queueList.Display();


        }
    }

}