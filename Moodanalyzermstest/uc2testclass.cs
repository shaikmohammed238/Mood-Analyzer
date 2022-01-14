using day20to22Moodanalyzer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Moodanalyzermstest
{
                                                   //Given Null Mood Should Return Happy
[TestClass]
    public class uc2testclass
    {
        [TestMethod]
        public void msgSadMood()
        {
            string msg = " ";
            string expected = "happy";

            uc2 obj = new uc2(msg);

            string actual = obj.Analyzemood();

            Assert.AreEqual(expected, actual);

        }
    }
}
