using Tyuiu.skirnevskyBR.Sprint0.Task2.V0.Lib;
namespace Tyuiu.skirnevskyBR.Sprint0.Task2.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Богдан";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет..., Богдан", res);
        }
    }
}
