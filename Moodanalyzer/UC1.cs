using System;
using System.Collections.Generic;
using System.Text;

namespace day20to22Moodanalyzer
{         /*Given a Message, ability
          to analyse and respond
           Happy or Sad Mood - Create MoodAnalyser Object - Call analyseMood function with message as
           parameter and return Happy or Sad Mood
           */
    public class UC1
    {
        private string message;
        public UC1(string message)
        {
            this.message = message;
        }
        public string Analyzemood()
        {
          if (this.message.Contains("sad"))
            {
                return "happy";
            }
            else
            {
                return "sad";
            }
        }
    }
}
