using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Virtual_01.Tests
{
    [TestClass]
    public class UnitTest1
    {
        private EmpleadoCA e;

        [TestInitialize]
        public void Startup()
        {
            e = new EmpleadoCA();
        }

        [TestMethod]
        public void Test01()
        {

            float resultado = e.CalcularSalarioBruto("vendedor", 2000, 8);
            float esperado = 1360;

            Assert.AreEqual(esperado, resultado);
        }

        [TestMethod]
        public void Test02()
        {
            float resultado = e.CalcularSalarioBruto("vendedor", 1500, 3);
            float esperado = 1260;

            Assert.AreEqual(esperado, resultado);
        }

        [TestMethod]
        public void Test03()
        {
            float resultado = e.CalcularSalarioBruto("vendedor", 1499.99f, 0);
            float esperado = 1100;

            Assert.AreEqual(esperado, resultado);
        }

        [TestMethod]
        public void Test04()
        {
            float resultado = e.CalcularSalarioBruto("encargado", 1250, 8);
            float esperado = 1760;

            Assert.AreEqual(esperado, resultado);
        }

        [TestMethod]
        public void Test05()
        {
            float resultado = e.CalcularSalarioBruto("encargado", 1000, 0);
            float esperado = 1600;

            Assert.AreEqual(esperado, resultado);
        }

        [TestMethod]
        public void Test06()
        {
            float resultado = e.CalcularSalarioBruto("encargado", 999.99f, 3);
            float esperado = 1560;

            Assert.AreEqual(esperado, resultado);
        }

        [TestMethod]
        public void Test07()
        {
            float resultado = e.CalcularSalarioBruto("encargado", 500, 0);
            float esperado = 1500;

            Assert.AreEqual(esperado, resultado);
        }

        [TestMethod]
        public void Test08()
        {
            float resultado = e.CalcularSalarioBruto("encargado", 0, 8);
            float esperado = 1660;

            Assert.AreEqual(esperado, resultado);
        }

        [TestMethod]
        public void Test09()
        {
            Assert.ThrowsException<CAExcepcion>(() => e.CalcularSalarioBruto("vendedor", -1, 8));
        }

        [TestMethod]
        public void Test10()
        {
            Assert.ThrowsException<CAExcepcion>(() => e.CalcularSalarioBruto("vendedor", 1500, -1));
        }

        [TestMethod]
        public void Test11()
        {
            Assert.ThrowsException<CAExcepcion>(() => e.CalcularSalarioBruto(null, 1500, 8));
        }

        [TestMethod]
        public void Test12()
        {
            float resultado = e.CalcularSalarioNeto(2000);
            float esperado = 1640;

            Assert.AreEqual(esperado, resultado);
        }
    }
}
