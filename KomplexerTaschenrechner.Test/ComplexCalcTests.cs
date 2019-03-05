using System;
using NUnit.Framework;

namespace KomplexerTaschenrechner.Test
{
    class ComplexCalcTests
    {
        [Test]
        [TestCase()]
        public void AddTest(string S1, string S2,string S3)
        {
            ComplexNumber C1 = ComplexNumber.Input(S1);
            ComplexNumber C2 = ComplexNumber.Input(S2);
            ComplexNumber C3 = ComplexNumber.Input(S3);
        }
    }
}
