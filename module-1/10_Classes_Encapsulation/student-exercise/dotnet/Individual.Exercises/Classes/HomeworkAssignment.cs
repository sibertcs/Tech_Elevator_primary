using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Exercises.Classes
{
    public class HomeworkAssignment
    {
        public int EarnedMarks { get; set; }

        public int PossibleMarks { get; }

        public string SubmitterName { get; }

        public string LetterGrade
        {
            get
            {
                double grade = (double) EarnedMarks / PossibleMarks * 100.0;
                
                if (grade >= 90)
                    return "A";
                else if (grade >= 80 && grade <= 89)
                    return "B";
                else if (grade >= 70 && grade <= 79)
                    return "C";
                else if (grade >= 60 && grade <= 69)
                    return "D";
                else
                    return "F";
                
            }

        }

        public HomeworkAssignment(int possibleMarks, string submitterName) 
        {
            SubmitterName = submitterName;
            PossibleMarks = possibleMarks;
        }
        

        

    }
}
