﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

namespace Grades2
{
    class Program
    {
        static void Main(string[] args)
        {

            GradeBook book = new GradeBook();

            book.Name = "Scott's Grade Book";
            book.Name = "Grade Book";
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);
            book.WriteGrades(Console.Out);

            GradeStatistics stats = book.ComputeStatistics();
            Console.WriteLine(book.Name);
            WriteResult("Average: ", stats.AverageGrade);
            WriteResult("Highest: ", stats.HighestGrade);
            WriteResult("Lowest: ", stats.LowestGrade);
            WriteResult(stats.Description, stats.LetterGrade);
            Console.ReadLine();
        }

        static void WriteResult(string description, float result)
        {
            Console.WriteLine(description + ": " + result);
        }

        static void WriteResult(string description, string result)
        {
            Console.WriteLine(description + ": " + result);
        }
    }
}
