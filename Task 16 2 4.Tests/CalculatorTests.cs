using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_16_2_4.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator _calculator;
        
        [SetUp]
        public void SetUp()
        {
            _calculator = new Calculator();
        }

        [Test]
        public void MultiplicationMustReturnNotNullValue()
        {
            var result = _calculator.Multiplicator(2, 4);
            
            Assert.AreEqual(8, result);
        }

        [Test]
        public void SubstructionMustReturnCorrectValue()
        {
            var result = _calculator.Subtraction(5, 4);

            Assert.That(result == 1);
        }

        [TestCase(3)]
        [TestCase(5)]
        public void DevisionMustReturnCorrectVolue(int value)
        {
            var result = _calculator.Devision(5, value);
            Assert.That(result == 1);
        }

        [TestCase(0)]
        public void DevisionMustThrowException(int value)
        {
            Assert.Throws < DivideByZeroException > (() => _calculator.Devision(5, value));
        }
    }
}
