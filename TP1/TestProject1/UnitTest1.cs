namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int nro1 = 2;
            int nro2 = 4;
            int esperado = 6;
            int actual = Program.Sumar(nro1, nro2);
            Assert.AreEqual(esperado, actual);
        }
    }
}