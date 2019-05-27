using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Calculatoreksamenslaesning.UnitTest
{
    [TestFixture]
    public class Class1
    {
        private Calculator _uut;

        [SetUp]
        public void Setup()
        {
            _uut = new Calculator();
        }

        [TestCase(2,5,7)]
        [TestCase(-2,-6,-8)]
        public void Addatob_returnresult(double a, double b, double result)
        {
            Assert.That(_uut.Add(a, b), Is.EqualTo(result));
        }

        [TestCase(5,4,1)]
        [TestCase(-6,-2,-4)]
        public void Subtractafromb_returnresult(double a, double b, double result)
        {
            Assert.That(_uut.Subtract(a,b), Is.EqualTo(result));
        }

        [TestCase(5,2,10)]
        [TestCase(-2,3,-6)]
        public void Multiplyatob_returnresult(double a, double b, double result)
        {
            Assert.That(_uut.Multiply(a,b), Is.EqualTo(result));
        }

        [TestCase(2,2,4)]
        [TestCase(3,3,27)]
        public void Power_returnresult(double x, double exp, double result)
        {
            Assert.That(_uut.Power(x,exp),Is.EqualTo(result));
        }
    }
}
