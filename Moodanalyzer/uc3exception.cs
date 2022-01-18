using System;
using System.Collections.Generic;
using System.Text;

namespace day20to22Moodanalyzer
{
    public class uc3exception : Exception
    {
        ExceptionType type;  //Create instance of custom exception type
        public string message;

        public enum ExceptionType  //enum for define constants
        {
            NULL_EXCEPTION, EMPTY_EXCEPTION
        }
        public uc3exception(ExceptionType type, string message) : base(message)  //parameterized constructor and also using bsae method
        {
            this.type = type;
        }
    }
}
