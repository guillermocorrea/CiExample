using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocio
{
    /// <summary>
    /// Calculator class
    /// </summary>
    public class Calculator
    {
        /// <summary>
        /// Add two numbers
        /// </summary>
        /// <param name="a">Number a</param>
        /// <param name="b">Number b</param>
        /// <returns>The sum of a plus b</returns>
        public static double Add(double a, double b)
        {
            return a + b;
        }

        public void DuplicateCode1()
        {
            double a = 1;
            double b = 1;
            if (a + b > 1)
                Console.WriteLine("Greater than 1");
        }

        public void DuplicateCode3()
        {
            double a = 1;
            double b = 1;
            if (a + b > 1)
                Console.WriteLine("Greater than 1");
        }

        public void DuplicateCode2()
        {
            double a = 1;
            double b = 1;
            if (a + b > 1)
                Console.WriteLine("Greater than 1");
            else
                Console.WriteLine("Less than 1");
        }
    }
}
