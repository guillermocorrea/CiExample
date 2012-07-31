using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Negocio;

namespace CiExample.Tests
{
    [TestFixture]
    public class CalculatorTest
    {
        [Test]
        public void OnePlusOneShouldBeOne()
        {
            double expected = 2.0;
            double result = Calculator.Add(1, 1);
            Assert.AreEqual(expected, result);
        }
    }
}
