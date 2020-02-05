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
                    //int fileCount = 1;
                    //int counter = 0;
                    //int lineCount = File.ReadLines(filePath).Count();
                    //string fileName = Path.GetFileNameWithoutExtension(filePath);
                    //string outputFile = fileName + "-" + fileCount + ".txt";

                    //using (StreamWriter sw = new StreamWriter(outputFile, false))                    
                    //{                       
                    //    string line = sr.ReadLine();
                    //    sw.WriteLine(line);
                    //    counter++;
                    //    if (counter == 3)
                    //    {
                    //        counter = 0;
                    //        fileCount++;
                    //    }
                    //}
                    int lineCount = File.ReadLines(filePath).Count();
                    for (int i = 0; i < lineCount; i++)
                    {

                        int fileCount = 0;
                        int counter = 0;
                        
                        string fileName = Path.GetFileNameWithoutExtension(filePath);
                        string outputFile = fileName + "-" + (fileCount) + ".txt";
                        using (StreamWriter sw = new StreamWriter(outputFile, true))
                        {
                            string line = sr.ReadLine();
                            sw.WriteLine(line);
                            counter++;
                            if (counter == 3)
                            {
                                counter = 0;
                                fileCount++;
                                sw.Close();
                                
                                

                            }



                        }

                    }

                }
            }
        }
    }
}
