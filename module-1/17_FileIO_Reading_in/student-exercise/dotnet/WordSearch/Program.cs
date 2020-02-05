using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace WordSearch
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //1. Ask the user for the search string
            //2. Ask the user for the file path
            //3. Open the file
            //4. Loop through each line in the file
            //5. If the line contains the search string, print it out along with its line number

            Console.WriteLine("What is fully qualified name of the file that should be searched?");
            string filePath = Console.ReadLine();

            Console.WriteLine("What is the search word you are looking for?");
            string searchString = Console.ReadLine();

            Console.WriteLine($"Should the search be case sensitive ? (Y\nN)");
            string answer = Console.ReadLine();
            bool isCaseSensitive = false;
            if (answer == "Y"|| answer == "y" || answer == "Yes" || answer == "yes")
            {
                isCaseSensitive = true;
            }

            FindSearchString(filePath, searchString, isCaseSensitive);

        }
        public static void FindSearchString(string filePath, string searchString, bool isCaseSensitive)
        {
            int lineNumber = 0;

            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        lineNumber++;
                        if (isCaseSensitive)
                        {
                            if (line.Contains(searchString))
                            {
                                Console.WriteLine($"{lineNumber}) {line}");
                            }
                                
                        }
                        else
                        {
                            if (line.Contains(searchString) || line.Contains(searchString.ToLower()))
                            Console.WriteLine($"{lineNumber}) {line}");
                        }
                        
                        
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Error reading the file");
                Console.WriteLine(e.Message);
            }
        }
    }
}
