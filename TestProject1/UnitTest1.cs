namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Проверка для a = 3
            int expected = 6; // 3! = 6
            Assert.AreEqual(expected, Var5.Class1.Fact(3));
        }
        [TestMethod]
        public void TestMethod2()
        {
            // Проверка для a = 1
            int expected = 1; // 1! = 1
            Assert.AreEqual(expected, Var5.Class1.Fact(1));
        }
        [TestMethod]
        public void TestMethod3()
        {
            // Проверка для a = 18
            long expected = 6402373705728000; // 18! = 6402373705728000
            Assert.AreEqual(expected, Var5.Class1.Fact(18));
        }
        [TestMethod]
        public void TestMethod4()
        {
            // Проверка для a = 9
            int expected = 362880; // 9! = 362880
            Assert.AreEqual(expected, Var5.Class1.Fact(9));
        }
    }
}