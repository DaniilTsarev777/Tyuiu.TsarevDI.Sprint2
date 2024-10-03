using Tyuiu.TsarevDI.Sprint2.Task1.V22.Lib;
namespace Tyuiu.TsarevDI.Sprint2.Task1.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetLogicOperations()
        {
            DataService ds = new DataService();
            int a, b, c, d;
            a = 324;
            b = 696;
            c = 254;
            d = 155;

            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);
            bool[] wait = new bool[6] { true, true, true, false, false, false };
            CollectionAssert.AreEqual(wait, res);


        }
    }
}