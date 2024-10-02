using Tyuiu.MedyanichevDI.Sprint3.Task0.V16.Lib;

namespace Tyuiu.MedyanichevDI.Sprint3.Task0.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double res = ds.GetMultiplySeries(5, 1, 6);
            Assert.AreEqual(res, 10220.275);
        }
    }
}