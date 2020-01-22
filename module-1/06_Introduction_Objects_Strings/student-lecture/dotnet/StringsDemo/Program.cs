using System;

namespace StringsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Ada Lovelace";

            // Strings are actually arrays of characters (char). 
            // Those characters can be accessed using [] notation.

            // 1. Write code that prints out the first and last characters
            //      of name.
            // Output: A           
            // Output: e
            Console.WriteLine("First and Last Character. ");
            Console.WriteLine(name[0] + " " + name[name.Length - 1]);
            

            // 2. How do we write code that prints out the first three characters
            // Output: Ada

            Console.WriteLine("First 3 characters: ");
            Console.WriteLine(name.Substring(0, 3));
            

            // 3. Now print out the first three and the last three characters
            // Output: Adaace

            Console.WriteLine("Last 3 characters: ");
            Console.WriteLine(name.Substring(name.Length - 3));

            // 4. What about the last word?
            // Output: Lovelace

            Console.WriteLine("Last Word: ");
            int space = (name.IndexOf(" "));
            string lastName = name.Substring(space + 1);
            Console.WriteLine("Last word: " + lastName);

            // 5. Does the string contain inside of it "Love"?
            // Output: true

            Console.WriteLine("Contains \"Love\"");
            Console.WriteLine(name.Contains("Love"));

            // 6. Where does the string "lace" show up in name?
            // Output: 8

            Console.WriteLine("Index of \"lace\": ");
            Console.WriteLine(name.IndexOf("lace"));

            int indexOfSecondLace = name.IndexOf("lace", name.IndexOf("lace") + 1);
            // 7. How many 'a's OR 'A's are in name?
            // Output: 3

            //options:

            //go through it like an array of characters and increment the count if it's a or A:
            int count = 0;
            for (int i = 0; i < name.Length; i++)
            {
                if (name[i].Equals("a") || name[i].Equals("A")); //can also use == operator for this, .Net has overload that allows for this
                {
                    count++;
                }
            }

            //find the index of A or a, increment count and then look through a substring to the right of that:
            string lowerName = name.ToLower();
            int indexOfA = lowerName.IndexOf("a");
            int countStr = 0; 
            while (indexOfA >= 0)
            {
                countStr++;
                if (indexOfA < lowerName.Length - 1)
                {
                    string subStr = lowerName.Substring(++indexOfA);
                    indexOfA = lowerName.IndexOf("a");
                }
                
            }



            Console.WriteLine("Number of \"a's\": ");


            // 8. Replace "Ada" with "Ada, Countess of Lovelace"

            Console.WriteLine(name);
            name = name.Replace("Ada", "Ada, Countess of Lovelace");
            Console.WriteLine(name);

            // 9. Set name equal to null.

            name = null;

            // 10. If name is equal to null or "", print out "All Done".
            if (name == null || name.Equals("")) //demonstrating using equals in multiple ways
            {
                Console.WriteLine("all done");
            }

            Console.ReadLine();
        }
    }
}