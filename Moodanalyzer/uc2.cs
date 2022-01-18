using System;
using System.Collections.Generic;
using System.Text;

namespace day20to22Moodanalyzer
{                                            // Handle Exception if User Provides Invalid Mood
     public class uc2
    {
        public string message;
        public uc2(string message)
        {
           this.message = message;
        }
        public string Analyzemood()
        {
            try
            {
                if (message.ToLower().Contains(""))
                    return "happy";
                else
                    return "sad";
            }
            catch(NullReferenceException )
            {
                return "happy";
            }
        }
    }
}
