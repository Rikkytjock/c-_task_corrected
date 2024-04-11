namespace StatisticsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Maximum_ReturnsMaximumValue()
        {

            int result = Statistics.Statistics.Maximum();


            int expectedMaximumValue = 378;
            Assert.AreEqual(expectedMaximumValue, result);
        }
    }
}