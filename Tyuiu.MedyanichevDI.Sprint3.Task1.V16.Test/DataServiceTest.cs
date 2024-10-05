using Tyuiu.MedyanichevDI.Sprint3.Task1.V16.Lib;

namespace Tyuiu.MedyanichevDI.Sprint3.Task1.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x =0.7;
            int s = 1;
            int e = 15;
            Assert.AreEqual(15.948, ds.GetSumSeries(x, s, e));
        }
    }
}