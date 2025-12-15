using Tyuiu.PlesovskikhBA.Sprint6.Task7.V10.Lib;
namespace Tyuiu.PlesovskikhBA.Sprint6.Task7.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMatrix()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\Administrator\source\repos\Tyuiu.PlesovskikhBA.Sprint6\TXTs\InPutDataFileTask7V10.csv";
            FileInfo file = new FileInfo(path);
            Assert.AreEqual(true, file.Exists);
        }
    }

}