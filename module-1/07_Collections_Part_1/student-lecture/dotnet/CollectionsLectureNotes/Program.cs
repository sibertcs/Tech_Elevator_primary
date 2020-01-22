using System;
using System.Collections.Generic;

namespace CollectionsLectureNotes
{
    class Program
    {
        static void Main(string[] args)
        {
            //

            // LIST<T>
            //
            // Lists allow us to hold collections of data. They are declared with a type of data that they hold
            // only allowing items of that type to go inside of them.
            //
            // The syntax used for declaring a new list of type T is
            //      List<T> list = new List<T>();
            //
            //

            // Creating lists of integers

            List<int> myList = new List<int>();
            List<int> secondList = new List<int>();


            // Creating lists of strings

            List<string> myListOfStrings = new List<string>();



            /////////////////


            //////////////////
            // OBJECT EQUALITY
            //////////////////




            /////////////////
            // ADDING ITEMS
            /////////////////

            // Adding items one at a time to each list
            // Adds them in order to the end of the list, unless list is empty
            myList.Add(4); //will be at index 0
            myList.Add(200); //will be at index 1
            myListOfStrings.Add("c# is great");

            /////////////////
            // ADDING MULTIPLE ITEMS
            /////////////////
            
            //to add an array to a list 
            int[] numsToAdd = { 4, 5, 6 };
            myList.AddRange(numsToAdd);
            //OR to add a list to a list
            myList.AddRange(secondList);


            //////////////////
            // ACCESSING BY INDEX
            //////////////////

            for (int i = 0; i < myList.Count; i++)
            {
                Console.Write(myList[i] + " ");
            }
            //OR
            for (int i = 0; i < myList.Count; i++)
            {
                Console.Write($"{myList[i]} ");
            }


            ///////////////////
            // ACCESSING WITH FOR-EACH
            ///////////////////
            
            foreach(int item in myList)
            {
                Console.WriteLine(item);
            }





            ////////////////////
            // ADDITIONAL LIST<T> METHODS
            ////////////////////

            bool contains2 = myList.Contains(2);
            Console.WriteLine($"is 2 in the list? {contains2}");

            //where is the number two

            myList.IndexOf(2);

            // to insert a number

            myList.Insert(0, 100); // places 100 at index 0


            ////////////////////////
            // SORT and PRINT A LIST
            ////////////////////////

            myList.Sort(); // sorts by numerical or alphabetical order

            myList.Reverse(); // reverses sorted order

            Console.WriteLine(String.Join(", ", myList)); //prints list separated by commas


            // QUEUE <T>
            //
            // Queues are a special type of data structure that follow First-In First-Out (FIFO).
            // With Queues, we Enqueue (add) and Dequeue (remove) items.

            //Create a queue of strings
            Queue<string> priorities = new Queue<string>();
            priorities.Enqueue("clean the dishes");
            priorities.Enqueue("wash the counters");
            priorities.Enqueue("sweep the floor");
            priorities.Enqueue("walk the dog");


            /////////////////////
            // PROCESSING ITEMS IN A QUEUE
            /////////////////////
            ///
            while (priorities.Count > 0)
            {
                string nextPriority = priorities.Dequeue();
                Console.WriteLine("Next priority: " + nextPriority);
            }



            // STACK <T>
            //
            // Stacks are another type of data structure that follow Last-In First-Out (LIFO).
            // With Stacks, we Push (add) and Pop (remove) items. Example: undo, browser movement

            Stack<string> browserStack = new Stack<string>();
            ////////////////////
            // PUSHING ITEMS TO THE STACK
            //////////////////// 

            browserStack.Push("www.google.com");
            browserStack.Push("www.cnn.com");
            browserStack.Push("www.facebook.com");
            browserStack.Push("twitch.tv");




            ////////////////////
            // POPPING THE STACK
            ////////////////////

            Console.WriteLine("peek: " + browserStack.Peek());

            while(browserStack.Count > 0)
            {
                string previousPage = browserStack.Pop();
                Console.WriteLine("previous page: " + previousPage);
            }

            Console.ReadLine();

        }
    }
}
