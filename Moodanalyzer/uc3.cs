using System;
using System.Collections.Generic;
using System.Text;

namespace day20to22Moodanalyzer
{
    /* UC3:- Inform user if entered Invalid Mood - In case of NULL or Empty Mood throw 
            Custom Exception MoodAnalysisException. 
            - Use Enum to differentiate the Mood Analysis Errors. 
    */
    public class uc3
    {
        public string message;  //instance variable


        public  uc3() //Constructors
        {

        }
        public  uc3(string message) //parameterized constructor for intilizing instance member
        {
            this.message = message;
            //this.methodName = methodName;
        }
        public string Analyzer()  //Analyzer method find mood
        {
            try  // Handling Exception
            {
                if (this.message.Equals(string.Empty))
                {

                    throw new uc3exception(uc3exception.ExceptionType.EMPTY_EXCEPTION, "Mood should not be empty");
                }
                else
                {
                    if (this.message.ToLower().Contains("happy"))
                    {
                        return "happy";
                    }
                    else
                    {
                        return "sad";
                    }
                }
            }
            catch (NullReferenceException ex)
            {
                //UC2 use -->// return ex.Message;
                // return "happy";
                throw new uc3exception(uc3exception.ExceptionType.NULL_EXCEPTION, "Mood should not be null");
            }
        }
    }
}
