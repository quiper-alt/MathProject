using System;
using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void TestSum()
        {
            Assert.AreEqual(5, MathProject.MathFormules.Sum(3,2));
            Assert.AreEqual(13, MathProject.MathFormules.Sum(6,7));
        }
        [Test]
        public void TestSub()
        {
            Assert.AreEqual(10, MathProject.MathFormules.Sub(16, 6));
            Assert.AreEqual(2, MathProject.MathFormules.Sub(5,3));
        }
        [Test]
        public void TestMultiplication()
        {
            Assert.AreEqual(48, MathProject.MathFormules.Multiplication(6,8));
            Assert.AreEqual(28, MathProject.MathFormules.Multiplication(7,4));
        }
        [Test]
        public void TestDivision()
        {
            Assert.AreEqual(6, MathProject.MathFormules.Division(48,8));
            Assert.AreEqual(4, MathProject.MathFormules.Division(28,7));
        }
        [Test]
        public void TestSquare()
        {
            Assert.AreEqual(25, MathProject.MathFormules.Square(5));
            Assert.AreEqual(49, MathProject.MathFormules.Square(7));
        }
        [Test]
        public void TestCubePower()
        {
            Assert.AreEqual(8, MathProject.MathFormules.CubePower(2));
            Assert.AreEqual(27, MathProject.MathFormules.CubePower(3));
        }
        [Test]
        public void TestSquaredSum()
        {
            Assert.AreEqual(25, MathProject.MathFormules.SquaredSum(3,2));
            Assert.AreEqual(25, MathProject.MathFormules.SquaredSum(4,1));
        }
        [Test]
        public void TestSquaredDifference()
        {
            Assert.AreEqual(1, MathProject.MathFormules.SquaredDifference(2,1));
            Assert.AreEqual(4, MathProject.MathFormules.SquaredDifference(4,6));
        }
        public void TestDiscriminant()
        {
            Assert.AreEqual(-8, MathProject.MathFormules.Discriminant(1,2,3));
            Assert.AreEqual(52, MathProject.MathFormules.Discriminant(-3,2, 4));
        }
        public void SquareTriangle()
        {
            Assert.AreEqual(2, MathProject.MathFormules.SquareTriangle(4,2));
            Assert.AreEqual(12, MathProject.MathFormules.SquareTriangle(8,3));
        }
    }
}