using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace QuizApp
{
    public partial class MainPage : ContentPage
    {
        List<Question> Questions { get; set; }
        public int NumCorrect { get; private set; }
        int Current { get; set; }
        public MainPage()
        {
            InitializeComponent();
            Questions = new List<Question> {
                new Question("The Sky Is Blue",1),
                new Question("This Class is Fun",1),
                new Question("Question 1 was False",0),
                new Question("Matt Green is a Great Teacher",1),
                new Question("Question 4 was False",0)
            };
            Current = 0;
            text.Text = Questions[0].MyQuestion;
            NumCorrect = 0;
        }
        async void OnButtonClicked(object sender, EventArgs args)
        {
            if (((Button)sender).Text=="True")
            {
                if (Questions[Current].Answer == 1)
                {
                    NumCorrect++;
                }
            }
            else
            {
                if (Questions[Current].Answer == 0)
                {
                    NumCorrect++;
                }
            }
            NextQuestion();
        }
        private void NextQuestion()
        {
            if (Current < Questions.Count - 1)
            {
                Current++;
                text.Text = Questions[Current].MyQuestion;
            }
            else
            {
                b1.IsVisible = false;
                b2.IsVisible = false;
                text.Text = "You Got " + NumCorrect + "/" + Questions.Count;
            }
        }
    }
}
