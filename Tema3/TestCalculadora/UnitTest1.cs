using Calculadora;

namespace TestCalculadora
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SumarDosNumeros()
        {
            double result = Calculadora.Calculadora.Suma(2, 4);
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void RestarDosNumeros()
        {
            double result = Calculadora.Calculadora.Resta(2, 4);
            Assert.AreEqual(-2, result);
        }

        [TestMethod]
        public void MultiplicarDosNumeros()
        {
            double result = Calculadora.Calculadora.Multiplicar(2, 4);
            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void DividirDosNumeros()
        {
            double result = Calculadora.Calculadora.Dividir(4, 2);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DividirEntreCero()
        {
            Calculadora.Calculadora.Dividir(4, 0);
        }
    }
}