using System;
using System.Collections.Generic;
using System.Text;

namespace file_io_part1_exercises
{
    class QuizQuestion
    {
        public string Question { get; set; }

        public string[] Answers { get; set; }

        public int CorrectAnswer { get; set; }
      

        public QuizQuestion() { }
        
        public QuizQuestion(string question, string[] answers, int correctAnswer)
        {
            this.Question = question;
            this.Answers = answers;
            this.CorrectAnswer = correctAnswer;
        }


    }
}
