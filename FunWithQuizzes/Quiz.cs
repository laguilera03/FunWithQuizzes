using System;
using System.Collections.Generic;
using System.Text;

namespace FunWithQuizzes
{
    class Quiz
    {
        /*
         * Add questions
         * Run or carry out the quiz
         * Grade the quiz
         */
        public Question Question { get; set; }

        //add questions list from the question class
        public Quiz(Question question) 
        {
            Question = question;
        }

        //return the questions graded and answered
        public override string ToString()
        {
            return "Grade: " + null;//return calculated grade
        }
    }
}
