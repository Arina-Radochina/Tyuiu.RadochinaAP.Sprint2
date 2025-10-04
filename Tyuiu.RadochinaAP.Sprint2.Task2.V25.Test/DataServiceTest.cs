using Tyuiu.RadochinaAP.Sprint2.Task2.V25.Lib;
namespace Tyuiu.RadochinaAP.Sprint2.Task2.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            int x = 5;
            int y = 6;

            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;

            Assert.AreEqual(wait, res);
        }
    }
}
