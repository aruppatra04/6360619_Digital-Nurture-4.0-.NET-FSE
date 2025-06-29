using NUnit.Framework;
using CalcLibrary;
using System;

namespace CalcLibrary.Tests
{
    [TestFixture]
    public class SimpleCalculatorTests
    {
        private SimpleCalculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new SimpleCalculator();
        }

        [TestCase(3, 2, 5)]
        [TestCase(-1, 1, 0)]
        public void Addition_ReturnsCorrectResult(double a, double b, double expected)
        {
            var result = _calculator.Addition(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(5, 3, 2)]
        [TestCase(2, 2, 0)]
        public void Subtraction_ReturnsCorrectResult(double a, double b, double expected)
        {
            var result = _calculator.Subtraction(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(4, 3, 12)]
        [TestCase(-2, 5, -10)]
        public void Multiplication_ReturnsCorrectResult(double a, double b, double expected)
        {
            var result = _calculator.Multiplication(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(10, 2, 5)]
        [TestCase(9, 3, 3)]
        public void Division_ReturnsCorrectResult(double a, double b, double expected)
        {
            var result = _calculator.Division(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Division_ByZero_ThrowsException()
        {
            var ex = Assert.Throws<ArgumentException>(() => _calculator.Division(5, 0));
            Assert.That(ex.Message, Is.EqualTo("Second Parameter Can't be Zero"));
        }

        [TearDown]
        public void Cleanup()
        {
            _calculator.AllClear();
        }
    }
}
