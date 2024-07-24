using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Classes
{
    public class Answer
    {
        public int Id { get; set; }
        public string AnswerText { get; set; }

        public Answer(int _Id ,string _AnswerText)
        {
            this.Id = _Id;
            this.AnswerText = _AnswerText;
        }

        public Answer()
        {
        }

        public override string ToString()
        {
            return $" {Id} : {AnswerText}";
        }
    }
}
