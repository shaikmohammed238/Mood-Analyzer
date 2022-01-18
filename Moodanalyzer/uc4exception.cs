using System;
using System.Collections.Generic;
using System.Text;

namespace day20to22Moodanalyzer
{
   public  class uc4exception : Exception
    {
        ExceptionType type;  //Create instance of custom exception type
        public string message;

        public enum ExceptionType  //enum for define constants
        {
            NULL_EXCEPTION, EMPTY_EXCEPTION, CONSTRUCTOR_NOT_FOUND, CLASS_NOT_FOUND, NO_SUCH_METHOD, NO_SUCH_FIELD, NULL_MESSAGE, FIELD_NULL, NULL
        }
        public uc4exception(ExceptionType type, string message) : base(message)  //parameterized constructor and also using bsae method
        {
            this.type = type;
        }
    }
}
