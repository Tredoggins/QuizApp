using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace QuizApp
{
    class Question
    {
        public Question(string question,byte answer)
        {
            this.MyQuestion = question;
            this.Answer = answer;
        }
        public string MyQuestion { private set; get; }
        public byte Answer { private set; get; }
    }
}
