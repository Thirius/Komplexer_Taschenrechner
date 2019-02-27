using System;
using NUnit.Framework;

namespace KomplexerTaschenrechner.Test
{
    public class ComplexNumberTests
    {
        [Test]
        [TestCase("2+5i", "5,385*(cos(68,199)+sin(68,199)i)", "5,385*e^68,199i")]
        [TestCase("5-8i", "9,434*(cos(302,005)+sin(302,005)i)", "9,434*e^302,005i")]
        public void ParseToStringTest(string cartesian, string polar, string exponential)
        {
            ComplexNumber cN = ComplexNumber.Input(cartesian);

            Assert.AreEqual(cartesian, cN.Cartesian());
            Assert.AreEqual(polar, cN.Polar());
            Assert.AreEqual(exponential, cN.Expo());
        }

        [Test]
        [TestCase("2+5i", 2, 5, 5.385, 68.199)]
        [TestCase("-5+3i", -5, 3, 5.831, 149.036)]
        [TestCase("5-8i", 5, -8, 9.434, 302.005)]
        [TestCase("-8-3i", -8, -3, 8.544, 200.556)]
        [TestCase("0-1i", 0, -1, 1, 270)]
        [TestCase("0+1i", 0, 1, 1, 90)]
        public void ParseCartesianTest(string input, double real, double imag, double absolute, double phi)
        {
            ComplexNumber cN = ComplexNumber.Input(input);

            Assert.AreEqual(real, cN.Real);
            Assert.AreEqual(imag, cN.Imag);
            Assert.AreEqual(phi, cN.Phi);
            Assert.AreEqual(absolute, cN.Absolute);
        }

        [Test]
        [TestCase("5,385*(cos(68,199)+sin(68,199)i)", 2, 5, 5.385, 68.199)]
        [TestCase("5,831*(cos(149,036)+sin(149,036)i)", -5, 3, 5.831, 149.036)]
        [TestCase("9,434*(cos(302,005)+sin(302,005)i)", 5, -8, 9.434, 302.005)]
        [TestCase("8,544*(cos(200,556)+sin(200,556)i)", -8, -3, 8.544, 200.556)]
        public void ParsePolarTest(string input, double real, double imag, double absolute, double phi)
        {
            ComplexNumber cN = ComplexNumber.Input(input);

            Assert.AreEqual(real, cN.Real);
            Assert.AreEqual(imag, cN.Imag);
            Assert.AreEqual(phi, cN.Phi);
            Assert.AreEqual(absolute, cN.Absolute);
        }

        [Test]
        [TestCase("8,544*(cos(0)+sin(200,556)i)", null)]
        public void PolarInputFailTest(string input, ComplexNumber tCN)
        {
            ComplexNumber cN = ComplexNumber.Input(input);
            Assert.AreEqual(tCN, cN);
        }

        [Test]
        [TestCase("8,544*(cos(0)+si(200,556)i)", null)]
        [TestCase("5+-2i", null)]
        [TestCase("5*e2i", null)]
        public void InputFailTest(string input, ComplexNumber tCN)
        {
            ComplexNumber cN = ComplexNumber.Input(input);
            Assert.AreEqual(tCN, cN);
        }

        [Test]
        [TestCase("5,385*e^68,199i", 2, 5, 5.385, 68.199)]
        [TestCase("5,831*e^149,036i", -5, 3, 5.831, 149.036)]
        [TestCase("9,434*e^302,005i", 5, -8, 9.434, 302.005)]
        [TestCase("8,544*e^200,556i", -8, -3, 8.544, 200.556)]
        public void ParseExponentialTest(string input, double real, double imag, double absolute, double phi)
        {
            ComplexNumber cN = ComplexNumber.Input(input);

            Assert.AreEqual(real, cN.Real);
            Assert.AreEqual(imag, cN.Imag);
            Assert.AreEqual(phi, cN.Phi);
            Assert.AreEqual(absolute, cN.Absolute);
        }
    }
}
