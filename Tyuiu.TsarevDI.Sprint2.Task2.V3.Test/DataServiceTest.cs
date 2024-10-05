using Tyuiu.TsarevDI.Sprint2.Task2.V3.Lib;
namespace Tyuiu.TsarevDI.Sprint2.Task2.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            int x, y;
            x = 3;
            y = 3;

            Assert.AreEqual(true, ds.CheckDotInShadedArea(x, y));
        }
    }
}