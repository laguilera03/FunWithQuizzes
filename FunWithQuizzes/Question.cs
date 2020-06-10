using System;
using System.Collections.Generic;
using System.Text;

namespace FunWithQuizzes
{
    class Question
    {
        //Create get set for values

        //Create a constructor for question / final answer
        //Create a subclass for Multiple choice, checkbox, true/false
        //sends question to the quiz class as a parameter in list format

        /* Class name
        Fields and properties with access modifiers
        Methods with access modifiers
        Any inheritance relationship
        */

        //ABCD multiple choice, 1234 checkbox, T or F for true or false
        //Multiple choice takes in string, int, char
        public string TheQuestion { get; set; }//Can't use Question as a name
        public string Answer { get; set; }
        public Question(string theQuestion, string answer)
        {
            TheQuestion = theQuestion;
            Answer = answer;
        }

        //Subclass Inheritance for Multiple choice, for checkbox, and for true and false
    }
    class TrueFalse
    {
        public string choices {this.Question }
    }
}
