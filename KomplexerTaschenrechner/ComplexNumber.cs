using System;
using System.Text.RegularExpressions;

namespace KomplexerTaschenrechner
{
    public class ComplexNumber
    {
        //double real, imag, absolute, phi;
        
        public double Real { get; set; }
        public double Imag { get; set; }
        public double Phi { get; set; }
        public double Absolute { get; set; }



        private void calcCart()
        {
            Real = Math.Round(Absolute * Math.Cos(Phi * (Math.PI / 180.0)), 3);
            Imag = Math.Round(Absolute * Math.Sin(Phi * (Math.PI / 180.0)), 3);
        }
        public void calcPhi()
        {
            double dummy = Math.Atan(Imag / Real);

            if (Real == 0 && Imag > 0)
                Phi = Math.PI/ 2;

            if (Real == 0 && Imag < 0)
                dummy = -Math.PI / 2;

            if (Real < 0 && Imag >= 0)
                dummy += Math.PI;

            if (Real < 0 && Imag < 0)
                dummy -= Math.PI;

            Phi = Math.Round(dummy * (180 / Math.PI) , 3);

            if (Phi < 0)
                Phi += 360;
        }

        public void calcAbsolute()
        {
            Absolute = Math.Round(Math.Sqrt(Math.Pow(Real, 2) + Math.Pow(Imag, 2)), 3);
        }

        public string Cartesian()
        {
            if(Imag < 0)
                return Real + "-" + Math.Abs(Imag) + "i";

            return Real + "+" + Imag + "i";
        }

        public string Polar()
        {
            return Absolute + "*(cos(" + Phi + ")+sin(" + Phi + ")i)";
        }

        public string Expo()
        {
            return Absolute + "*e^" + Phi + "i";
        }

        static public ComplexNumber Input(string text)
        {
            ComplexNumber cN = new ComplexNumber();
            string cartesianPattern = @"^(?<real>-?(\d+([,]\d+)?))(?<imaginary>([+-])(\d+([,]\d+)?))i(\s+)?$";
            string exponentialPattern = @"^(?<absolute>-?(\d+([,]\d+)?))\*e\^(?<phi>(\d+([,]\d+)?))i(\s+)?$";
            string polarPattern = @"^(?<absolute>-?(\d+([,]\d+)?))\*\(cos\((?<phi>(\d+([,]\d+)?))\)\+sin\((?<phi2>(\d+([,]\d+)?))\)i\)(\s+)?$";
            if (Regex.IsMatch(text, cartesianPattern))
            {
                Match match = Regex.Match(text, cartesianPattern);
                double real = double.Parse(match.Groups["real"].Value);
                double imag = double.Parse(match.Groups["imaginary"].Value);
                cN.Real = real;
                cN.Imag = imag;
                cN.calcAbsolute();
                cN.calcPhi();
            }
            else if (Regex.IsMatch(text, exponentialPattern))
            {
                Match match = Regex.Match(text, exponentialPattern);
                double absolute = double.Parse(match.Groups["absolute"].Value);
                double phi = double.Parse(match.Groups["phi"].Value);
                cN.Phi = phi;
                cN.Absolute = absolute;
                cN.calcCart();
            }
            else if (Regex.IsMatch(text, polarPattern))
            {
                Match match = Regex.Match(text, polarPattern);
                double absolute = double.Parse(match.Groups["absolute"].Value);
                double phi = double.Parse(match.Groups["phi"].Value);
                double phi2 = double.Parse(match.Groups["phi2"].Value);

                if (phi != phi2)
                    return null;

                cN.Phi = phi;
                cN.Absolute = absolute;
                cN.calcCart();
            }
            else return null;

            return cN;
        }
    } 
}
