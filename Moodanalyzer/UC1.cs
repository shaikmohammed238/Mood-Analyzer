using System;
using System.Collections.Generic;
using System.Text;

namespace day20to22Moodanalyzer
{
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
                return "sad";
            }
            else
            {
                return "happy";
            }
        }
    }
}
