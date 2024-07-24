namespace Exam.Classes
{
    public class FinalExam : Exam
    {
        public FinalExam(int _Time, int _NoOfQuestion) : base(_Time, _NoOfQuestion)
        {
        }

        public override void CreateListQuestion()
        {
            QuestionsList = new Question[NoOfQuestion];
            for (int i = 0; i < QuestionsList.Length; i++)
            {
                int QuestionType;
                do
                {
                    Console.WriteLine("1 For MCQ | 2 For True or False");
                } while (!int.TryParse(Console.ReadLine(), out QuestionType) || (QuestionType < 1 || QuestionType > 2));

                Console.Clear();
                if (QuestionType == 1)
                {
                    QuestionsList[i] = new MCQQuestion();//dynamic binding parent from child
                    QuestionsList[i].CreateQuestion();
                }
                else
                {
                    QuestionsList[i] = new TrueOrFalseQuestion();
                    QuestionsList[i].CreateQuestion();

                }
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

                } while (!int.TryParse(Console.ReadLine(),out UserAnswerId)&&(UserAnswerId<1 ||UserAnswerId>3));
                question.UserAnswer=new Answer(UserAnswerId, question.AnswerList[UserAnswerId-1].AnswerText);
                Console.WriteLine("----------------------------");
            }
            Console.Clear();




            int AllMark = 0;
            int grade = 0;
            foreach (var question in QuestionsList)
            {
                AllMark += question.Mark;
                if (question.CorrectAnswer.Id == question.UserAnswer.Id)
                {
                    grade += question.Mark;
                }
            }
            Console.WriteLine("Correct Answer: \n");
            foreach (var question1 in QuestionsList)
            {

                Console.WriteLine($"{question1.Body}======>Correct Answer = {question1.CorrectAnswer.AnswerText}" + 
                    $" ,User Answer ={question1.UserAnswer.AnswerText} ");


                Console.WriteLine($"Student Grade ={grade}/{AllMark}");

            }
        }
    }
}
