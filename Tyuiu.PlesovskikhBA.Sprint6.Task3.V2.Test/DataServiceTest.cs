using Tyuiu.PlesovskikhBA.Sprint6.Task3.V2.Lib;
namespace Tyuiu.PlesovskikhBA.Sprint6.Task3.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] matrix = new int[5, 5] {
                { -12, -4, -20, 5, -5 },
                { 2, 15, 1, -20, 7 },
                { 15, -15, 2, 11, 5 },
                { -19, -9, 16, 0, 1 },
                { 17, 16, 5, 12, -8 }
            };

            int[,] result = ds.Calculate(matrix);

            Assert.AreEqual(0, result[0, 0]);
            Assert.AreEqual(0, result[0, 1]);
            Assert.AreEqual(0, result[0, 2]);
            Assert.AreEqual(5, result[0, 3]);
            Assert.AreEqual(-5, result[0, 4]);
            Assert.AreEqual(2, result[1, 0]);
            Assert.AreEqual(15, result[1, 1]);
            Assert.AreEqual(1, result[1, 2]);
            Assert.AreEqual(-20, result[1, 3]);
            Assert.AreEqual(7, result[1, 4]);
        }
    }
}
