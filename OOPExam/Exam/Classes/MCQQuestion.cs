using System;

namespace Exam.Classes
{
    internal class MCQQuestion : Question
    {
        public override string Header
        {
            get
            {
                return "MCQ (Choose Correct Answer)";
            }
        }

        public override void CreateQuestion()
        {
            Console.WriteLine(Header);
            Console.WriteLine("Input the Body Of Question");
            Body = Console.ReadLine() ?? "No Question Body Entered";

            int mark;

            Console.WriteLine("Enter Marks of Question");

            while (!int.TryParse(Console.ReadLine(), out mark) || mark < 1)
            {
                Console.WriteLine("Invalid input. Please enter a valid integer for the marks:");
            }
            Mark = mark;

            AnswerList = new Answer[3];
            Console.WriteLine("The Choices Of Question");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Enter Choice Number {i + 1}");
                AnswerList[i] = new Answer(i + 1, Console.ReadLine() ?? "Input String Only");
            }

            Console.WriteLine("Enter Correct Choice (1, 2, 3)");
            int correctAnswer;
            while (!int.TryParse(Console.ReadLine(), out correctAnswer) || correctAnswer < 1 || correctAnswer > 3)
            {
                Console.WriteLine("Invalid input. Please enter a valid integer for the Choice:");
            }
            CorrectAnswer = new Answer(AnswerList[correctAnswer - 1].Id, AnswerList[correctAnswer - 1].AnswerText);
        }
    }
}
