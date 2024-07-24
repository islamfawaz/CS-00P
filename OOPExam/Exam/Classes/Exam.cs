using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Classes
{
    public abstract class Exam
    {
        public int Time { get; set; }
        public int NoOfQuestion { get; set; }

      public Question[] QuestionsList { get; set; }
        public Exam(int _Time ,int _NoOfQuestion) {
            this.Time = _Time;
            this.NoOfQuestion = _NoOfQuestion;
        }

        public abstract void CreateListQuestion();
        public abstract void DisplayExam();
        
    } 
}
