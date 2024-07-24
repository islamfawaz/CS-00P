using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Classes
{
     public abstract class Question
    {
         public abstract string Header { get;}
        public string Body { get; set; }

        public int Mark { get; set; }
        public Answer[] AnswerList { get; set; }

        public Answer UserAnswer { get; set; }

        public Answer CorrectAnswer { get; set; }


        public Question()
        {
            UserAnswer = new Answer();
          CorrectAnswer = new Answer();
        }
        public abstract void CreateQuestion();

        public override string ToString()
        {
            return $"{Header}   Mark\n {Body}";
        }
    }
}
