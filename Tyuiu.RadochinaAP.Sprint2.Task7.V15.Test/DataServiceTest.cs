using Tyuiu.RadochinaAP.Sprint2.Task7.V15.Lib;
namespace Tyuiu.RadochinaAP.Sprint2.Task7.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            double x = -1;
            double y = 1;

            bool res = ds.CheckDotInShadedArea(x, y);

            bool wait = true;

            Assert.AreEqual(wait, res);
        }
    }
}
