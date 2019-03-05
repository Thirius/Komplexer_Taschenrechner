using System;

namespace KomplexerTaschenrechner
{
    class ComplexCalc
    {
        public ComplexNumber Add(ComplexNumber C1, ComplexNumber C2)
        {
            if (C1 == null || C2 == null)
                return null;
            ComplexNumber result = new ComplexNumber();
            result.Real = C1.Real + C2.Real;
            result.Imag = C1.Imag + C2.Imag;
            return ComplexNumber.Input(result.Cartesian());
        }
        public ComplexNumber Subtract(ComplexNumber C1, ComplexNumber C2)
        {
            if (C1 == null || C2 == null)
                return null;
            ComplexNumber result = new ComplexNumber();
            result.Real = C1.Real - C2.Real;
            result.Imag = C1.Imag - C2.Imag;
            return ComplexNumber.Input(result.Cartesian());
        }

        public ComplexNumber Multiply(ComplexNumber C1, ComplexNumber C2)
        {
            if (C1 == null || C2 == null)
                return null;
            ComplexNumber result = new ComplexNumber();
            result.Real = C1.Real * C2.Real + C1.Imag * C2.Imag;
            result.Imag = C1.Imag * C2.Real + C2.Imag * C1.Real;
            return ComplexNumber.Input(result.Cartesian());
        }

        public ComplexNumber Divide(ComplexNumber C1, ComplexNumber C2)
        {
            if (C1 == null || C2 == null)
                return null;
            ComplexNumber result = new ComplexNumber();
            result.Real = (C1.Real * C2.Real + C1.Imag * C2.Imag) / (Math.Pow(C2.Real, 2) + Math.Pow(C2.Imag, 2));
            result.Imag = (C1.Imag * C2.Real - C1.Real * C2.Imag) / (Math.Pow(C2.Real, 2) + Math.Pow(C2.Imag, 2));
            return ComplexNumber.Input(result.Cartesian());
        }

    }
}
