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

        [TestMethod]
        public void TestMethod2()
        {
            int nro1 = 2;
            Boolean retorno1 = Program.MayorElse(nro1);
            Assert.AreEqual(false, retorno1);

            int nro2 = 11;
            Boolean retorno2 = Program.MayorElse(nro2);
            Assert.AreEqual(true, retorno2);
        }
    }
}