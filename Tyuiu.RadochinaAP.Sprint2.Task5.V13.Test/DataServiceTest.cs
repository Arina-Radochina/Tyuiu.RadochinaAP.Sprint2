using Tyuiu.RadochinaAP.Sprint2.Task5.V13.Lib;

namespace Tyuiu.RadochinaAP.Sprint2.Task5.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfNextDay()
        {
            DataService ds = new DataService();

            Assert.AreEqual("2024-2-29", ds.FindDateOfNextDay(2024, 2, 28)); 
            Assert.AreEqual("2024-3-1", ds.FindDateOfNextDay(2024, 2, 29)); 
            Assert.AreEqual("2024-6-16", ds.FindDateOfNextDay(2024, 6, 15)); 
            Assert.AreEqual("2024-5-1", ds.FindDateOfNextDay(2024, 4, 30));  
            Assert.AreEqual("2025-1-1", ds.FindDateOfNextDay(2024, 12, 31)); 

            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindDateOfNextDay(2024, 2, 30); 
            });

            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindDateOfNextDay(2024, 13, 1); 
            });

            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindDateOfNextDay(2024, 1, 0); 
            });
        }    
    }
}