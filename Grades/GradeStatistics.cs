using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class GradeStatistics
    {
        public GradeStatistics()
        {
            HighestGrade = 0;
            LowestGrade = float.MaxValue;

        }

        public string Description
        {
            get
            {
                string result;
                switch (LetterGrade)
                {
                    case "A":
                        result = "Great Job!";
                        break;
                    case "B":
                        result = "Well Done";
                        break;
                    case "C":
                        result = "Keep Studying";
                        break;
                    case "D":
                        result = "Try Harder";
                        break;
                    default:
                        result = "See me after class!";
                        break;
                }
                return result;
            }

        }
        public string LetterGrade
        {
            get
            {
                string result;
                if(AverageGrade >= 90)
                {
                    result = "A";
                }
                else if (AverageGrade >= 80)
                {
                    result = "B";
                }
                else if (AverageGrade >= 70)
                {
                    result = "C";
                }
                else if (AverageGrade >= 60)
                {
                    result = "D";
                }
                else
                {
                    result = "F";
                }

                return result;
            }
        }
        public float AverageGrade;
        public float HighestGrade;
        public float LowestGrade;
    }
}
