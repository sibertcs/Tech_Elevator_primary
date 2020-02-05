using System;
using System.IO;

namespace FizzWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            string directory = @"C:\Users\Student\workspace\csibert-c\module-1\18_FileIO_Writing_out\student-exercise\dotnet";
            string fileName = "FizzBuzz.txt";
            string fullPath = Path.Combine(directory, fileName);

            ModifyWithFizzBuzz(fullPath);

            Console.WriteLine("FizzBuzz.txt has been created.");
        }
        public static void ModifyWithFizzBuzz(string fullPath)
        {
            using (StreamWriter sw = new StreamWriter(fullPath, false))
            {
                for (int i = 1; i <= 300; i++)
                {
                    bool three = i.ToString().Contains(3.ToString());
                    bool five = i.ToString().Contains(5.ToString());
                    if (i % 5 == 0 && i % 3 == 0)
                    {
                        sw.WriteLine("FizzBuzz");
                    }
                    else if (three || i % 3 == 0)
                    {
                        sw.WriteLine("Fizz");
                    }
                    else if (five || i % 5 == 0)
                    {                       
                        sw.WriteLine("Buzz");
                    }
                    else
                    {
                        sw.WriteLine(i);
                    }
                }
            }
        }

    }
}
