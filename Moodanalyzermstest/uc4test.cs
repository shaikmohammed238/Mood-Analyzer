using day20to22Moodanalyzer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Moodanalyzermstest
{
    [TestClass]
    class uc4test
    {
        /* TC 4.1:- Given MoodAnalyser Class Name Should Return MoodAnalyser Object
                    - Create MoodAnalyser Factory to create a MoodAnalyser Object with default constructor
                    - Use Equals method in MoodAnalyser to check if the two objects are equal.
                    - Test passes if they are equal.
        */

        [TestMethod]
        public void GivenMoodAnalyseClass_ShouldReturn_MoodAnalyserObject()
        {
            string message = null;
            object expected = new uc4(message);
            uc4factory factory = new uc4factory();
            object obj = factory.CreateMoodAnalyzerObject("MoodAnalyzerProblem.MoodAnalyzer", "MoodAnalyzer");
            expected.Equals(obj);
        }

        /* TC 4.2:- Given Class Name When Improper Should Throw MoodAnalysisException
                    - To pass this test case pass wrong class name catch Exception and throw 
                    Exception indicating No Such Class Error.
         */
        [TestMethod]
        public void MoodAnalyseClass_GivenWrongClassName_ShouldReturn_NOClassException()
        {
            string expected = "Class not found";
            try
            {
                string message = null;              
                object moodAnalyser = new uc4(message);
                uc4factory factory = new uc4factory();
                factory = new uc4factory();
                object obj = factory.CreateMoodAnalyzerObject("MoodAnalyzerProblem.MoodAnalyzer", "MoodAnalyzer");
                moodAnalyser.Equals(obj);
            }
            catch (uc4exception ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }

        }
        /*TC 4.3:- Given Class When Constructor Not Proper Should Throw MoodAnalysisException.
                  - To pass this Test Case pass wrong Constructor parameter, catch the Exception and throw indicating No 
                   Such Method Error. 
        */
        [TestMethod]
        public void MoodAnalyseClass_GivenWrongConstructorName_ShouldReturn_NoConstructorException()
        {
            string expected = "Constructor not found";
            try
            {
                string message = null;                
                object moodAnalyser = new uc4(message);
                uc4factory factory = new uc4factory();
                object obj = factory.CreateMoodAnalyzerObject("MoodAnalyzerProblem.MoodAnalyzer", "MoodAnalyzer");
                moodAnalyser.Equals(obj);
            }
            catch (uc4exception ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }

        }
    }
}
