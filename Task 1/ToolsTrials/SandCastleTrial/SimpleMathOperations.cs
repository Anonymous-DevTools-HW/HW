using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandCastleTrial
{
    /// <summary>
    /// Contains methods performing some simple math operations on integers.
    /// </summary>
    public class SimpleMathOperations
    {
        /// <summary>
        /// Sums two integers.
        /// </summary>
        /// <param name="a">Fitst Integer</param>
        /// <param name="b">Second Integer</param>
        /// <returns>Result from summing the integers.</returns>
        public static int Sum(int a, int b)
        {
            return a + b;
        }

        /// <summary>
        /// Subtracts the second integer from the first.
        /// </summary>
        /// <param name="a">Fitst Integer</param>
        /// <param name="b">Second Integer</param>
        /// <returns>Result from subtracting the integers.</returns>

        public static int Subtract(int a, int b)
        {
            return a - b;
        }

        /// <summary>
        /// Multiplies two integers.
        /// </summary>
        /// <param name="a">Fitst Integer</param>
        /// <param name="b">Second Integer</param>
        /// <returns>Result from multiplying the integers.</returns>

        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        /// <summary>
        /// Divides the firts integer with the second.
        /// </summary>
        /// <param name="a">Fitst Integer</param>
        /// <param name="b">Second Integer</param>
        /// <returns>Result from dividing the integers.</returns>

        public static int Divide(int a, int b)
        {
            return a / b;
        }
    }
}
