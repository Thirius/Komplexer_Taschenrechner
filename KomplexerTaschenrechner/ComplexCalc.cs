using System;

namespace KomplexerTaschenrechner
{
    public class ComplexCalc
    {
        static public ComplexNumber Add(ComplexNumber C1, ComplexNumber C2)
        {
            if (C1 == null || C2 == null)
                return null;

            ComplexNumber result = new ComplexNumber();
            result.Real = Math.Round(C1.Real + C2.Real,3);
            result.Imag = Math.Round(C1.Imag + C2.Imag,3);
            return ComplexNumber.Input(result.Cartesian());
        }
        static public ComplexNumber Subtract(ComplexNumber C1, ComplexNumber C2)
        {
            if (C1 == null || C2 == null)
                return null;
            ComplexNumber result = new ComplexNumber();
            result.Real = Math.Round(C1.Real - C2.Real,3);
            result.Imag = Math.Round(C1.Imag - C2.Imag,3);
            return ComplexNumber.Input(result.Cartesian());
        }

        static public ComplexNumber Multiply(ComplexNumber C1, ComplexNumber C2)
        {
            if (C1 == null || C2 == null)
                return null;
            ComplexNumber result = new ComplexNumber();
            result.Phi = C1.Phi + C2.Phi;
            result.Absolute = C1.Absolute * C2.Absolute;
            return ComplexNumber.Input(result.Expo());
        }

        static public ComplexNumber Divide(ComplexNumber C1, ComplexNumber C2)
        {
            if (C1 == null || C2 == null)
                return null;
            ComplexNumber result = new ComplexNumber();
            result.Real = Math.Round((C1.Real * C2.Real + C1.Imag * C2.Imag) / (Math.Pow(C2.Real, 2) + Math.Pow(C2.Imag, 2)),3);
            result.Imag = Math.Round(((C1.Imag * C2.Real) - (C1.Real * C2.Imag)) / (Math.Pow(C2.Real, 2) + Math.Pow(C2.Imag, 2)),3);
            return ComplexNumber.Input(result.Cartesian());
        }

    }
}
