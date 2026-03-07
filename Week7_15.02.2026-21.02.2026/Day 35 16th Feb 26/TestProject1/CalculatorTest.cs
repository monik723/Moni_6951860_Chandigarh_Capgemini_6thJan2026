using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using CalculatorApp;

namespace TestProject1
{
    [TestFixture]
    internal class CalculatorTest
    {
        private Calculator calc;
        [SetUp]
        public void SetUp()
        {
            calc = new Calculator();
        }
        [Test]
        public void Add_TwoNumbers_ReturnSum()
        {
            //Arrange
            int a = 10, b = 2;

            //Act
            int result = calc.Add(a, b);

            //Assert
            Assert.That(result, Is.EqualTo(12));
        }

        [Test]
        public void Subtract_TwoNumbers_ReturnDifference()
        {
            //Arrange
            int a = 10, b = 2;

            //Act
            int result = calc.Subtract(a, b);

            //Assert
            Assert.That(result, Is.EqualTo(8));
        }

        [Test]
        public void Multiply_TwoNumbers_ReturnMultiplication()
        {
            //Arrange
            int a = 10, b = 2;

            //Act
            int result = calc.Multiply(a, b);

            //Assert
            Assert.That(result, Is.EqualTo(20));
        }

        [Test]
        public void Divide_ByZero_ThrowsException()
        {
            //Arrange
            int a = 10, b = 0;

            //Act & Assert
            Assert.Throws<DivideByZeroException>(() => calc.Division(a, b));
        }

        [Test]
        public void Divide_TwoNumbers_ReturnDivision()
        {
            //Arrange
            int a = 10, b = 2;

            //Act
            int result = calc.Division(a, b);

            //Assert
            Assert.That(result, Is.EqualTo(5));
        }
    }
}
