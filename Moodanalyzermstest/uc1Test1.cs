using Microsoft.VisualStudio.TestTools.UnitTesting;
using day20to22Moodanalyzer;


namespace Moodanalyzermstest
{
    [TestClass]
    public class uc1Test1
    {
        [TestMethod]   //  Given “I am in Sad  Mood” messageShould Return SAD  test case1
        
        public void Given_sad_mood_return_sad_mood()
        {
            ////Arrange
            //string expected = "sad";
            //string message = " im sad mood";
            //UC1 moodanalyze = new UC1(message);
            ////Act
            //string mood = moodanalyze.Analyzemood();
            //// assert
            //Assert.AreEqual(expected, mood);
        }
        // TEST CASE2 Given “I am in Any Mood” message Should Return HAPPY

        public void Given_I_am_in_Any_Mood()
        {
            //Arrange
            string expected = "happy";
            string message = " im any mood";
            UC1 moodanalyze = new UC1(message);
            //Act
            string mood = moodanalyze.Analyzemood();
            // assert
            Assert.AreEqual(expected, mood);
        }

    }   
}
