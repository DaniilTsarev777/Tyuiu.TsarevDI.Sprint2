using Tyuiu.TsarevDI.Sprint2.Task4.V12.Lib;
namespace Tyuiu.TsarevDI.Sprint2.Task4.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition()
        {
            DataService ds = new DataService();
            double x, y;
            x = 2;
            y = 0.5;
            Assert.AreEqual(225, ds.Calculate(x, y));
        }
    }
}