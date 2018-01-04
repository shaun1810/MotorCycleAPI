using System;
using System.Collections.Generic;
namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeBook book = new GradeBook();
            book.NameChange += OnNameChanged;
            /*book.Name = "Hello, this is the Gradebook program!";
            Console.WriteLine(book.Name);
            book.Name = "The GradeBook Welcomes thee!";*/
            book.Name = "Shaun's book";
            book.AddGrade(78);
            book.AddGrade(99.444f);
            book.AddGrade(80);
            book.WriteGradesForLoop(Console.Out);
            book.WriteGradesForEachLoop(Console.Out);
            book.WriteGradesWhileLoop(Console.Out);
            Statistics stats = book.ComputeStatistics();
            if (stats.GetActiveStats() == true)
            {
                writeResult("Highest Grade" , stats.GetHighestGrade()); 
                writeResult("Lowest Grade" ,  stats.GetLowestGrade());
                writeResult("Average Grade" , stats.GetAverGrade());
                writeResult(stats.Description, stats.LetterGrade);
            }
            else
            {
                Console.WriteLine("There are no grades to compute!");
            }
        }   

        static void writeResult(string message, float gradeResult)
        {
                Console.WriteLine($"{message}: {gradeResult:f2}", message, gradeResult);
        }

          static void writeResult(string message, string gradeResult)
        {
                Console.WriteLine($"{message}: {gradeResult}", message, gradeResult);
        }

       /*  static void writeGrades(string message, int gradeResult)
        {
                Console.WriteLine("{0}: {1:f2}", message , gradeResult);
        }*/

        static void OnNameChanged(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine($"Name of book changing from {args.CurrentName} to {args.NewName}");

        }
    }
}