using System;
using NUnit.Framework;

namespace KomplexerTaschenrechner.Test
{
    class ComplexCalcTests
    {
        [Test]
        [TestCase("3+4i", "5+2i", "8+6i")]
        [TestCase("7+5i", "3+3i", "10+8i")]
        [TestCase("7-5i", "-3+3i", "4-2i")]
        public void AddTest(string S1, string S2, string S3)
        {
            ComplexNumber C1 = ComplexNumber.Input(S1);
            ComplexNumber C2 = ComplexNumber.Input(S2);

            Assert.AreEqual(S3, ComplexCalc.Add(C1, C2).Cartesian());
        }

        [Test]
        [TestCase("", "")]
        [TestCase("2+3i", "2")]
        [TestCase("2+3", "2+4i")]
        public void AddNullTest(string S1, string S2)
        {
            ComplexNumber C1 = ComplexNumber.Input(S1);
            ComplexNumber C2 = ComplexNumber.Input(S2);
            ComplexNumber result = ComplexCalc.Add(C1, C2);

            Assert.IsNull(result);
        }

        [Test]
        [TestCase("8+4i", "5+2i", "3+2i")]
        [TestCase("7+6i", "3+3i", "4+3i")]
        [TestCase("7-5i", "-3+3i", "10-8i")]
        public void SubtractTest(string S1, string S2, string S3)
        {
            ComplexNumber C1 = ComplexNumber.Input(S1);
            ComplexNumber C2 = ComplexNumber.Input(S2);

            Assert.AreEqual(S3, ComplexCalc.Subtract(C1, C2).Cartesian());
        }

        [Test]
        [TestCase("", "")]
        [TestCase("2+3i", "2")]
        [TestCase("2+3", "2+4i")]
        public void SubtractNullTest(string S1, string S2)
        {
            ComplexNumber C1 = ComplexNumber.Input(S1);
            ComplexNumber C2 = ComplexNumber.Input(S2);
            ComplexNumber result = ComplexCalc.Subtract(C1, C2);

            Assert.IsNull(result);
        }

        [Test]
        [TestCase("5-2i", "3+4i", "22,999+14i")]
        [TestCase("2-4i", "-3+5i", "14+22i")]
        public void MultiplyTest(string S1, string S2, string S3)
        {
            ComplexNumber C1 = ComplexNumber.Input(S1);
            ComplexNumber C2 = ComplexNumber.Input(S2);

            Assert.AreEqual(S3, ComplexCalc.Multiply(C1, C2).Cartesian());
        }

        [Test]
        [TestCase("", "")]
        [TestCase("2+3i", "2")]
        [TestCase("2+3", "2+4i")]
        public void MultiplyNullTest(string S1, string S2)
        {
            ComplexNumber C1 = ComplexNumber.Input(S1);
            ComplexNumber C2 = ComplexNumber.Input(S2);
            ComplexNumber result = ComplexCalc.Multiply(C1, C2);

            Assert.IsNull(result);
        }

        [Test]
        [TestCase("2+1i", "1-2i", "0+1i")]
        [TestCase("2+3i", "1-4i", "-0,588+0,647i")]
        public void DivideTest(string S1, string S2, string S3)
        {
            ComplexNumber C1 = ComplexNumber.Input(S1);
            ComplexNumber C2 = ComplexNumber.Input(S2);

            Assert.AreEqual(S3, ComplexCalc.Divide(C1, C2).Cartesian());
        }

        [Test]
        [TestCase("", "")]
        [TestCase("2+3i", "2")]
        [TestCase("2+3", "2+4i")]
        public void DivideNullTest(string S1, string S2)
        {
            ComplexNumber C1 = ComplexNumber.Input(S1);
            ComplexNumber C2 = ComplexNumber.Input(S2);
            ComplexNumber result = ComplexCalc.Divide(C1, C2);

            Assert.IsNull(result);
        }
    }
}
