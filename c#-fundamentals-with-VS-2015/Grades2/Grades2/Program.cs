using System;
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

            //SpeechSynthesizer synth = new SpeechSynthesizer();
            //synth.SelectVoice("");
            //synth.Speak("Hello! This is the grade book program");

            GradeBook book = new GradeBook();
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);
/*            book.AddGrade(75);
            book.AddGrade(75);
            book.AddGrade(45);
            book.AddGrade(35);
            book.AddGrade(65);
            book.AddGrade(55);
            */

            //GradeBook book2 = new GradeBook();
            //book2.AddGrade(75);
            GradeStatistics stats = book.ComputeStatistics();
            Console.WriteLine(stats.AverageGrade);
            Console.WriteLine(stats.HighestGrade);
            Console.WriteLine(stats.LowestGrade);
            Console.ReadLine();
        }
    }
}
