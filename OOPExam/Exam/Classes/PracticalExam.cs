using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Classes
{
    internal class PracticalExam : Exam
    {
        public PracticalExam(int _Time, int _NoOfQuestion) : base(_Time, _NoOfQuestion)  {}

        public override void CreateListQuestion()
        {
            QuestionsList = new MCQQuestion[NoOfQuestion];

            for (int i = 0; i < QuestionsList ?.Length; i++)
            {
                QuestionsList[i] = new MCQQuestion(); 
                QuestionsList[i].CreateQuestion();     
                Console.Clear();
            }
        }

        public override void DisplayExam()
        {
            foreach (var question in QuestionsList)
            {
                Console.WriteLine(question.ToString());
                foreach (var answer in question.AnswerList)
                {
                    Console.WriteLine(answer.ToString());
                }
                int UserAnswerId;
                do
                {
                    Console.WriteLine("Enter Your Answer");

                } while (!int.TryParse(Console.ReadLine(), out UserAnswerId) && (UserAnswerId < 1 || UserAnswerId > 3));
                question.UserAnswer = new Answer(UserAnswerId, question.AnswerList[UserAnswerId - 1].AnswerText);
                Console.WriteLine("----------------------------");
            }
            Console.Clear();


            Console.WriteLine("Correct Answer\n");
            foreach (var question in QuestionsList)
            {
                Console.WriteLine ($"{question.Body}======>Correct Answer = {question.CorrectAnswer}");
            }
        }
    }
}
