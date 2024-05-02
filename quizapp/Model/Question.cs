using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quizapp.Model
{
    public class Question
    {
        public int QuizId { get; set; }
        public string Name { get; set; }

        public Question(int QuizId, string Name)
        {
            this.QuizId = QuizId;
            this.Name = Name;
        }
    }
}
