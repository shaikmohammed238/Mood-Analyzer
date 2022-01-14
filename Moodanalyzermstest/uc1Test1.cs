using Microsoft.VisualStudio.TestTools.UnitTesting;
using day20to22Moodanalyzer;


namespace Moodanalyzermstest
{
    [TestClass]
    public class uc1Test1
    {
        [TestMethod]
        public void Given_sad_mood_return_sad_mood()
        {
            //Arrange
            string expected = "happy";
            string message = " im happy mood";
            UC1 moodanalyze = new UC1(message);
            //Act
            string mood = moodanalyze.Analyzemood();
            // assert
            Assert.AreEqual(expected, mood);
        }
    }
}
