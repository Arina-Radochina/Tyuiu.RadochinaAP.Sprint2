using Tyuiu.RadochinaAP.Sprint2.Task3.V1.Lib;

namespace Tyuiu.RadochinaAP.Sprint2.Task3.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {

            DataService ds = new DataService();
            double x = 8;
            double res = ds.Calculate(x);
            double wait = 2884.812;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 2;
            double res = ds.Calculate(x);
            double wait = -17.027;
            Assert.AreEqual(wait, res);
        }


        [TestMethod]
        public void ValidCondition3()
        {
            DataService ds = new DataService();
            double x = -1;
            double res = ds.Calculate(x);
            double wait = -10;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition4()
        {
            DataService ds = new DataService();
            double x = -6;
            double res = ds.Calculate(x);
            double wait = -65.995;
            Assert.AreEqual(wait, res);
        }
    }

}
