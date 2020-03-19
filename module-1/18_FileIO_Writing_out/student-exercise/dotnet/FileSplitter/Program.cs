using System;
using System.IO;

namespace FileSplitter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //prompt the user for the input file
            string input = "input.txt";

            //prompt the user for the number of lines
            int numLines = 10;

            //open the input file for reading
            using (StreamReader sr = new StreamReader(input))
            {
                int fileNum = 1;
                string outputFile = GenerateOutputFileName(input,fileNum);
                //open the first output file
                StreamWriter sw = new StreamWriter(outputFile,false);
                int linesWritten = 0;
                while (!sr.EndOfStream)
                {
                    
                    //if the number of lines that i've written to the output is less than 10

                    string line = sr.ReadLine();
                    if (linesWritten < 10)
                    {
                        //write it and increment
                        sw.WriteLine(line);
                        linesWritten++;
                    }
                    else // otherwise create a new file  write it and set linesWritten to 1
                    {
                        sw.Close(); //close existing
                        fileNum++;
                        outputFile = GenerateOutputFileName(input, fileNum);
                        sw = new StreamWriter(outputFile,false);
                        sw.WriteLine(line);
                        linesWritten = 1;
                    }


                    
                }
                sw.Close();
                sw.Close();
            }
        }

        private static string GenerateOutputFileName(string inFile,int fileNum)
        {
            return "input-1.txt";
        }
    }
}
