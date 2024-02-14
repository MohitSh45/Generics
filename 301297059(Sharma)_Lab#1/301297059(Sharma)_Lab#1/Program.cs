using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _301297059_Sharma__Lab_1
{

    internal class Program
    {
       
        static void Main(string[] args)
        {
            // Array
            int[] number = { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine(" Array List :");
            for(int i = 0;i < number.Length; i++)
            {
                Console.WriteLine(number[i]);
            }
            //Linked List
            LinkedList<String> mohit_list = new LinkedList<String>();
            mohit_list.AddFirst("Jammy");
            mohit_list.AddLast("Sachin");
            mohit_list.AddLast("Rohit");
            mohit_list.AddLast("Gabbar");
            mohit_list.AddLast("Dhoni");
            mohit_list.AddFirst("Moses");
            Console.WriteLine("\n Linked List :");
            foreach(var rr in mohit_list)
            {
                Console.WriteLine(rr);
            }
            //Stack
            Stack mohit_stack = new Stack();
            mohit_stack.Push("Jesus Christ");
            mohit_stack.Push(7);
            mohit_stack.Push("Moses");
            mohit_stack.Push("Mathew");
            Console.WriteLine("\n Stack List: ");
            foreach(var ee in mohit_stack) {
                Console.WriteLine(ee);
            }
            //Queue
            Queue mohit_queue = new Queue();
            mohit_queue.Enqueue("Mohit Sharma");
            mohit_queue.Enqueue(3);
            mohit_queue.Enqueue("Gabbar");
            mohit_queue.Enqueue(30);
            Console.WriteLine("\n Queue");
            foreach (var ff in mohit_queue)
            {
                Console.WriteLine(ff);
            }
            
            StringBuilder sb = new StringBuilder("This is to test whether the extension method count can return a right answer or not");

            int wordCount = sb.WordCount();
            Console.WriteLine($"\nNumber of words: {wordCount}");

            Console.WriteLine("\nAthlete List Before Addition");
            MedalManager.show();

            Console.WriteLine("\nAthlete List After Addition");
            MedalManager.add();
            MedalManager.show();

           
            Console.WriteLine("\nAthlete List After  Deletion");
            MedalManager.delete();
            MedalManager.show();

            string searchName = "Michael Phelps";
            var searchResultsByName = MedalManager.Search(m => m.Athlete, searchName);
            Console.WriteLine($"\nSearch Results for Name '{searchName}':");
            foreach (var result in searchResultsByName)
            {
                Console.WriteLine(result);
            }

        }
    }
}
