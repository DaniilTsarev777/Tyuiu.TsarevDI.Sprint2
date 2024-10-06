using Tyuiu.TsarevDI.Sprint2.Task3.V14.Lib;
namespace Tyuiu.TsarevDI.Sprint2.Task3.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition()
        {
            DataService ds = new DataService();
            double x;
            x = 1.0;

            Assert.AreEqual(2.0, ds.Calculate(x));
        }
    }
}