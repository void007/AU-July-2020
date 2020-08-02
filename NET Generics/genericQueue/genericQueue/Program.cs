using System;
using System.Collections.Generic;

namespace genericQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> q = new Queue<string>();
            q.Enqueue("Mandeep");
            q.Enqueue("Yadav");
            q.Enqueue("Assignment");
            q.Enqueue("Determination");
            q.Enqueue("Hard-work");
            q.Enqueue("that's..it");

            print(q);
            Console.WriteLine("Retrieve using peak:");
            Console.WriteLine(q.Peek());

            Console.WriteLine("Remove two elements from the queue:");
            q.Dequeue();
            q.Dequeue();
            Console.WriteLine("Updated queue is:\n");
            print(q);


        }
        public static void print(Queue<string> q)
        {
            foreach(string name in q)
            {
                Console.WriteLine(name);
            }
        }
    }
}
