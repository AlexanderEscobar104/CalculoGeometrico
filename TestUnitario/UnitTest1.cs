namespace TestUnitario
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCalcularRadio()
        {
            CalculoGeometrico.Program program = new CalculoGeometrico.Program();
            double resultado;
            resultado = program.calcularRadio(20);
            Assert.AreEqual(3.184713375796178, resultado);
        }

        [TestMethod]
        public void TestCalcularBaseAltura()
        {
            CalculoGeometrico.Program program = new CalculoGeometrico.Program();
            double resultado;
            resultado = program.calcularBase(12 , 12);
            Assert.AreEqual(144, resultado);
        }
    }
}