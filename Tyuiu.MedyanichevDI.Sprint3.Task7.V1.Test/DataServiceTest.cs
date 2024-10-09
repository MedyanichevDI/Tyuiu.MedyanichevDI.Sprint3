using Tyuiu.MedyanichevDI.Sprint3.Task7.V1.Lib;

namespace Tyuiu.MedyanichevDI.Sprint3.Task7.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //[-12.18,16.03,18.87,4.96,-9.99,-2.0,2.16,-7.54,-22.76,-20.45,7.77]
            DataService ds = new DataService();
            Assert.AreEqual([-12.18, 16.03, 18.87, 4.96, -9.99, -2.0, 2.16, -7.54, -22.76, -20.45, 7.77], ds.GetMassFunction(-5, 5));
        }
    }
}