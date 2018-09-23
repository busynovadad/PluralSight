using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades2
{
    public class GradeBook
    {
        public GradeBook()
        {
            grades = new List<float>();
        }

        public GradeStatistics ComputeStatistics()
        {
//            return new GradeStatistics();
            GradeStatistics stats = new GradeStatistics();

            float sum = 0;
            foreach(float grade in grades)
            {
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                sum += grade;
            }
            stats.AverageGrade = sum / grades.Count;
            return stats;
        }

        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        private List<float> grades;
    }
}
