using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Classes
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Exam ExamSubject { get; set; }
        public Subject(int _Id, string _Name)
        {
            Id = _Id;
            Name = _Name; 
        }
        public void CreateExam()
        {
            int ExamType, ExamTime, NoOfQuestion;
           
            do
            {
                Console.WriteLine("Choose Exam Type: 1 For Practical, 2 For Final");
            } while (!int.TryParse(Console.ReadLine(), out ExamType) || (ExamType < 1 || ExamType > 2));

            do
            {
                Console.WriteLine("Input Duration Of Exam in Minutes:");

            } while (!int.TryParse(Console.ReadLine(), out ExamTime) || (ExamTime < 1 ));



            do
            {
                Console.WriteLine("Enter No Of Question :");

            } while (!int.TryParse(Console.ReadLine(), out NoOfQuestion) || (NoOfQuestion < 1));

            if (ExamType==1)
            {
                ExamSubject = new PracticalExam(ExamTime,NoOfQuestion);
            }
            else
            {
                ExamSubject = new FinalExam(ExamTime, NoOfQuestion);
            }
            Console.Clear();
            ExamSubject.CreateListQuestion();
        }
        public void DisplayExam()
        {
            ExamSubject.DisplayExam();
        }

    }
}
