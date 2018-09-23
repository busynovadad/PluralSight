using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech;
using System.Speech.Synthesis;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            //SpeechSynthesizer ss = new SpeechSynthesizer();
            //ss.Speak("Dude. You've found the grade book program.");

            GradeBook book = new GradeBook();
            book.AddGrade(991);
            book.AddGrade(89.5f);
            book.AddGrade(89.5f);
            book.AddGrade(89.5f);
            book.AddGrade(89.5f);
            book.AddGrade(89.5f);

            GradeStatistics stats = book.ComputeStatistics();
            Console.WriteLine(stats.AverageGrade);
            Console.WriteLine(stats.HighestGrade);
            Console.WriteLine(stats.LowestGrade);

            //GradeBook book2 = book;
            //book2.AddGrade(123);
        }
    }
}
