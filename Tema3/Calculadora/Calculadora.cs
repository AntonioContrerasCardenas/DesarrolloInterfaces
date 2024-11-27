using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    /// <summary>
    /// Proporciona métodos para realizar operaciones matemáticas básicas.
    /// </summary>
    public static class Calculadora
    {

        /// <summary>
        /// Suma dos números.
        /// </summary>
        /// <param name="a">El primer número.</param>
        /// <param name="b">El segundo número.</param>
        /// <returns>La suma de los dos números.</returns>
        public static double Suma(double a, double b)
        {
            return a + b;
        }

        /// <summary>
        /// Resta el segundo número del primero.
        /// </summary>
        /// <param name="a">El número del cual se resta.</param>
        /// <param name="b">El número que se resta.</param>
        /// <returns>La diferencia entre los dos números.</returns>
        public static double Resta(double a, double b)
        {
            return a - b;
        }

        /// <summary>
        /// Multiplica dos números.
        /// </summary>
        /// <param name="a">El primer número.</param>
        /// <param name="b">El segundo número.</param>
        /// <returns>El producto de los dos números.</returns>
        public static double Multiplicar(double a, double b)
        {
            return a * b;
        }

        /// <summary>
        /// Divide el primer número entre el segundo.
        /// </summary>
        /// <param name="a">El numerador.</param>
        /// <param name="b">El denominador.</param>
        /// <returns>El cociente de la división.</returns>
        /// <exception cref="DivideByZeroException">Se produce si el denominador es cero.</exception>
        public static double Dividir(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException("No se puede dividir entre cero.");
            return a / b;

        }
    }
}
