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

            //*
            GradeBook book = new GradeBook();
            book.NameChanged += OnNameChanged;
            book.NameChanged += OnNameChanged2;
            book.NameChanged += OnNameChanged2;
            book.NameChanged -= OnNameChanged2;
            //book.NameChanged += new NameChangedDelegate(OnNameChanged);
            //book.NameChanged += new NameChangedDelegate(OnNameChanged2);
            //book.NameChanged += new NameChangedDelegate(OnNameChanged2);
            //book.NameChanged = null;

            book.Name = "Scott's Grade Book";
            book.Name = "Grade Book";
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);

            GradeStatistics stats = book.ComputeStatistics();
            Console.WriteLine(book.Name);
            WriteResult("Average: ", stats.AverageGrade);
            WriteResult("Highest: ", (int)stats.HighestGrade);
            WriteResult("Lowest: ", stats.LowestGrade);
             //           */

            /*
            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;

            g1.Name = "g1name";
            Console.WriteLine(g2.Name);
*/

            Console.ReadLine();

        }

        static void OnNameChanged(string existingName, string newName)
        {
            Console.WriteLine($"Grade book changing name from {existingName} to {newName}");
        }

        static void OnNameChanged(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine($"Grade book changing name from {args.ExistingName} to {args.NewName}");
        }

        static void OnNameChanged2(string existingName, string newName)
        {
            Console.WriteLine("***");
        }

        static void OnNameChanged2(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine("***");
        }

        static void WriteResult(string description, float result)
        {
            Console.WriteLine(description + ": " + result);
        }

        static void WriteResult(string description, int result)
        {
            Console.WriteLine($"{description}: {result:F2}");
        }

    }
}
