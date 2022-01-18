using day20to22Moodanalyzer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Moodanalyzermstest
{
    [TestClass]
    public class uc3test
    {
        [TestMethod]
        public void NullMood()
        {
            string msg = " ";
            string expected = "sad";

            uc3 mood = new uc3(msg);

            string actual = mood.Analyzer();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void getCustomNullException()
        {
            string expected = "message should not be null";
            uc3 modeAnalyzer = new uc3(" ");

            try
            {
                string actual = modeAnalyzer.Analyzer();

            }
            catch (Exception ex )
            {
                Assert.AreEqual(expected,ex.Message);
            }
        }

        [TestMethod]
        public void getCustomEmptyException()
        {
            string expected = "message should not be empty";
            uc3 modeAnalyzer = new uc3(string.Empty);

            try
            {
                string actual = modeAnalyzer.Analyzer();

            }
            catch (Exception EX )
            {
                Assert.AreEqual(expected,EX.Message);
            }

        }
    }
}
