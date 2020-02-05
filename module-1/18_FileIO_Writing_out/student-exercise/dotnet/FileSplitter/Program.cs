using System;
using System.IO;
using System.Linq;

namespace FileSplitter
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Environment.CurrentDirectory);
            Console.WriteLine("Where is the input file (please include the path to the file) ?");
            string filePath = Console.ReadLine();

            while (!File.Exists(filePath))
            {
                Console.WriteLine("Error. The file doesn't exist. Please specify a file that exists.");
                Console.WriteLine("Where is the input file (please include the path to the file) ?");
                filePath = Console.ReadLine();
            }

            Console.WriteLine("How many lines of text (max) should there be in the split files?");
            int numberLinesPerFile = int.Parse(Console.ReadLine());

            FileSplitter(filePath, numberLinesPerFile);

            Console.WriteLine("**GENERATING OUTPUT**");

        }
        public static void FileSplitter(string filePath, int numberLinesPerFile)
        {
            using (StreamReader sr = new StreamReader(filePath))
            {
                while (!sr.EndOfStream)
                {                   
                    int lineCount = File.ReadLines(filePath).Count();
                    int fileSuffix = 1;
                    int linesWritten = 0;

                    string fileName = Path.GetFileNameWithoutExtension(filePath);

                    for (int i = 0; i < lineCount; i++)
                    {                       
                        using (StreamWriter sw = new StreamWriter(($"{fileName}-{fileSuffix}.txt"), true))
                        {                                                   
                            sw.WriteLine(sr.ReadLine());            
                            linesWritten++;
                            if (linesWritten == numberLinesPerFile)
                            {
                                fileSuffix++;
                                linesWritten = 0;
                            }
                        }
                    }
                }
            }
        }
    }
}
