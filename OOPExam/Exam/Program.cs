using System;
using System.Diagnostics;
using Exam.Classes;

namespace Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject(1, "C#");
            subject.CreateExam();

            char choice;
            do
            {
                Console.WriteLine("Do you want to take the exam? (y/n): ");
            } while (!char.TryParse(Console.ReadLine().ToLower(), out choice) || (choice != 'y' && choice != 'n'));

            if (choice == 'y')
            {
                Console.Clear();
                Stopwatch sw = Stopwatch.StartNew();
                subject.DisplayExam();
                Console.WriteLine($"Time for Exam is {sw.Elapsed}");
            }
            else if (choice == 'n')
            {
                Console.WriteLine("Exam closed Thank U.");
            }
        }
    }
}
