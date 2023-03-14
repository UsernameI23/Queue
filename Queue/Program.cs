using System;
using System.Collections.Generic;

namespace Queues
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Queue<string> grocery = new Queue<string>();

            
            grocery.Enqueue("Milk");
            grocery.Enqueue("Juice");
            grocery.Enqueue("Pineapple");
            grocery.Enqueue("Bread");
            grocery.Enqueue("Jam");

            foreach (var g in grocery)
            {
                Console.WriteLine(g);
            }

            
            string firstMem = grocery.Peek();
            Console.WriteLine($"Would you like to remove {firstMem} from the beginning of the list (yes or no)?");
            string answer = Console.ReadLine();
            while (answer == "yes")
            {
                grocery.Dequeue(); 
                firstMem = grocery.Peek();
                Console.WriteLine($"Would you like to remove {firstMem} from the beginning of the queue (yes or no)?");
                answer = Console.ReadLine();
            }

            if (grocery.Peek() == null)
                Console.WriteLine("The queue is empty");
            else
                Console.WriteLine($"You have {grocery.Count} left in the list");

        }
    }
}
