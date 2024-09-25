using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    [TestFixture]
    public class OperationsNUnitTest
    {
        [Test]
        public void Add_InputNumbers_ResturnNumber()
        {
            // 1. Arrange
            Operations operations = new();
            int n1 = 2;
            int n2 = 5;
            int expectedResult = 7;
            int limitUpResult = 8;
            int limitDownResult = 6;

            // 2. Act
            int result = operations.Add(n1, n2);

            // 3. Assert
            Assert.That(result, Is.EqualTo(expectedResult));
            Assert.That(result, Is.Not.EqualTo(limitUpResult));
            Assert.That(result, Is.Not.EqualTo(limitDownResult));
        }



        [Test]
        [TestCase (10)]
        [TestCase (12)]
        [TestCase (20)]
        public void IsEven_InputNumber_ResturnTrue(int n)
        {
            // 1. Arrange
            Operations operations = new();

            // 2. Act
            bool result = operations.IsEven(n);

            // 3. Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(1.7, 3.8)]
        public void AddDouble_InputNumbers_ResturnNumber(double d1, double d2)
        {
            // 1. Arrange
            Operations operations = new();
            double expectedResult = 5.5;
            double limitUpResult = 6;
            double limitDownResult = 4.5;

            // 2. Act
            double result = operations.AddDouble(d1, d2);

            // 3. Assert
            Assert.That(result, Is.EqualTo(expectedResult).Within(0.1));
            Assert.That(result, Is.Not.EqualTo(limitUpResult));
            Assert.That(result, Is.Not.EqualTo(limitDownResult));
        }
    }

}
