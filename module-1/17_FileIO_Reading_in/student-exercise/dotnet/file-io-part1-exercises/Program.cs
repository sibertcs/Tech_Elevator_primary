using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace file_io_part1_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Environment.CurrentDirectory);
            string path = Environment.CurrentDirectory;
            string file = "sample-quiz-file.txt";

            string filePath = Path.Combine(path, file);

            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    List<QuizQuestion> listOfQuestions = new List<QuizQuestion>();
                    int numberOfQuestionsCorrect = 0;
                    int numberOfQuestionsAttempted = 0;
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        string[] splitLine = line.Split("|");
                        int count = 1;
                        

                        string question = splitLine[0];
                        string[] possibleAnswers = new string[splitLine.Length - 1];
                        int correctAnswer = 0;

                        int j = 0;
                        for (int i = 1; i < splitLine.Length; i++)
                        {
                            
                            possibleAnswers[j] = splitLine[i];
                            if (possibleAnswers[j].Contains("*"))
                            {
                                correctAnswer = j + 1;
                                possibleAnswers[j] = possibleAnswers[j].Substring(0, possibleAnswers[j].Length - 1);
                               
                            }
                            j++;
                        }

                        
                        QuizQuestion newQuestion = new QuizQuestion(question, possibleAnswers, correctAnswer);
                        listOfQuestions.Add(newQuestion);


                        Console.WriteLine(newQuestion.Question);
                        foreach (string item in possibleAnswers)
                        {
                            Console.WriteLine($"{count}. {item}");
                            count++;
                        }
                        int userAnswer = int.Parse(Console.ReadLine());
                        
                        Console.WriteLine($"Your answer: {userAnswer}");
                        if (userAnswer == correctAnswer)
                        {
                            Console.WriteLine("RIGHT!");
                            numberOfQuestionsCorrect++;
                            numberOfQuestionsAttempted++;

                        }
                        else
                        {
                            Console.WriteLine("WRONG!");
                            numberOfQuestionsAttempted++;
                        }                       
                        Console.ReadLine();

                    }
                    Console.WriteLine($"You got {numberOfQuestionsCorrect} answer(s) correct out of the {numberOfQuestionsAttempted} questions asked.");

                }
            }
            catch
            {

            }
        }
            

    }
}
