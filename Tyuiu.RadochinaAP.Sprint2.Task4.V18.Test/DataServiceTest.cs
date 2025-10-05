using Tyuiu.RadochinaAP.Sprint2.Task4.V18.Lib;

namespace Tyuiu.RadochinaAP.Sprint2.Task4.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 4;
            double res = ds.Calculate(x, y);
            double wait = 41.5;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 4;
            double y = 8;
            double res = ds.Calculate(x, y);
            double wait = 83.75;
            Assert.AreEqual(wait, res);
        }
    }
}
