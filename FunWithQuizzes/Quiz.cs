using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks.Dataflow;

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
        public List<string> quizList = new List<string>();
        //quizList.Add("What color are apples?");

        //add questions list from the question class
        public Quiz(Question question) 
        {
            Question = question;
        }

        //write method to grade the list of answers

        //return the questions graded and answered
        public override string ToString()
        {
            return "Grade: " + null;//return calculated grade
        }
    }
}
