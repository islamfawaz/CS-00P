using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Classes
{
    internal class TrueOrFalseQuestion : Question
    {

       

        public override string Header =>"TRUE OR FALSE Question";

        public TrueOrFalseQuestion()
        {
            AnswerList = new Answer[2]
            {
                new Answer(1,"True"),
                new Answer(2,"False"),
            };
        }




        public override void CreateQuestion()
        {
            Console.WriteLine("Enter Body of Question");
            Body=Console.ReadLine() ??"string only";
            int mark;

            Console.WriteLine("Input Marks of Question");

            while (!int.TryParse(Console.ReadLine(), out mark) && mark < 1)
            {
                Console.WriteLine("Invalid input. Please enter a valid integer for the marks:");
            }
            Mark = mark;


            Console.WriteLine("Enter Correct Choice(1,2)");
            int correctAnswer;
            while (!int.TryParse(Console.ReadLine(), out correctAnswer) && (correctAnswer < 1 || correctAnswer > 2))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer for the Choice:");
            }
            CorrectAnswer = new Answer(AnswerList[correctAnswer - 1].Id, AnswerList[correctAnswer - 1].AnswerText);
        }
    }
}
