using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace KomplexerTaschenrechner.Client
{
    public partial class Calc : Form
    {

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        List<describeComplexNumber> listComplex = new List<describeComplexNumber>();

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void MouseDownEvent(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        public Calc()
        {
            InitializeComponent();

            pnl_info.Visible=true;
            pnl_calc.Visible=false;
            pnl_easyCalc.Visible = false;

            tip.SetToolTip(txt_complex, "A + bi \n'Abs'*e^'Phi'i \n'Abs'*(cos('Phi')+si('Phi')i)\n 'Abs' = Betrag ");
            tip.SetToolTip(txt_number1, "A + bi \n'Abs'*e^'Phi'i \n'Abs'*(cos('Phi')+si('Phi')i)\n 'Abs' = Betrag ");
            tip.SetToolTip(txt_number2, "A + bi \n'Abs'*e^'Phi'i \n'Abs'*(cos('Phi')+si('Phi')i)\n 'Abs' = Betrag ");

        }

        private void btn_Min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        List<char> lnumber = new List<char>(new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', ','});
        List<char> loperator = new List<char>(new char[] { '-', '+', '*', 'i', '^', 'e', 's', 'n', 'c', 'o', '(', ')' });

        private void txt_Calc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
                e.KeyChar = ',';

            if (!loperator.Contains(e.KeyChar) && !lnumber.Contains(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        ComplexNumber cN;
        ComplexNumber C1 = new ComplexNumber();
        ComplexNumber C2 = new ComplexNumber();
        bool extended = false;

        private void txt_complex_TextChanged(object sender, EventArgs e)
        {
            cN = ComplexNumber.Input(txt_complex.Text);
            if (cN == null)
            {

                lbl_cartesian.Text = "";
                lbl_exponential.Text = "";
                lbl_polar.Text = "";
                lbl_phi.Text = "";
                lbl_absolute.Text = "";
                lbl_conjugate.Text = "";
                return;
            }

            lbl_phi.Text = cN.Phi.ToString();
            lbl_absolute.Text = cN.Absolute.ToString();
            lbl_conjugate.Text = cN.Conjugate();
            lbl_cartesian.Text = cN.Cartesian();
            lbl_exponential.Text = cN.Expo();
            lbl_polar.Text = cN.Polar();
        }

        private void btn_info_Click(object sender, EventArgs e)
        {
            btn_calc.Text = "Erweitert";
            if (pnl_info.Visible)
                return;

            pnl_calc.Visible = false;
            pnl_easyCalc.Visible = false;
            extended = false;

            if (lbl_result.Text != "")
                txt_complex.Text = lbl_result.Text;

            else if (txt_number1.Text != "")
                txt_complex.Text = txt_number1.Text;

            else if (txt_number2.Text != "")
                txt_complex.Text = txt_number2.Text;

            txt_number1.Text = "";
            txt_number2.Text = "";
            lbl_result.Text = "";
            pnl_info.Visible = true;
        }

        private void btn_calc_Click(object sender, EventArgs e)
        {

            extended = true;
            if (pnl_calc.Visible)
            {
                if (lbl_result.Text == "")
                    return;
                txt_number1.Text = lbl_result.Text;
                txt_number2.Text = "";
                lbl_result.Text = "";
                return;
            }

            btn_calc.Text = "Weiter";
            pnl_info.Visible = false;
            pnl_easyCalc.Visible = false;
            if (txt_complex.Text != "")
                txt_number1.Text = txt_complex.Text;

            txt_complex.Text = "";
            pnl_calc.Visible = true;
            
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (extended)
            {
                C1 = ComplexNumber.Input(txt_number1.Text);
                C2 = ComplexNumber.Input(txt_number2.Text);
            }
            else
            {
                setEasyComplexNumbers();
            }

            lbl_result.Text = ComplexCalc.Add(C1, C2)?.Cartesian();
            txt_result2.Text = lbl_result.Text;

            if (lbl_result.Text == "")
                MessageBox.Show("Fehler bei der Eingabe");
        }

        private void btn_subtract_Click(object sender, EventArgs e)
        {
            if (extended)
            {
                C1 = ComplexNumber.Input(txt_number1.Text);
                C2 = ComplexNumber.Input(txt_number2.Text);
            }
            else
            {
                setEasyComplexNumbers();
            }

            lbl_result.Text = ComplexCalc.Subtract(C1, C2)?.Cartesian();
            txt_result2.Text = lbl_result.Text;

            if (lbl_result.Text == "")
                MessageBox.Show("Fehler bei der Eingabe");
        }

        private void btn_multiply_Click(object sender, EventArgs e)
        {
            if (extended)
            {
                C1 = ComplexNumber.Input(txt_number1.Text);
                C2 = ComplexNumber.Input(txt_number2.Text);
            }
            else
            {
                setEasyComplexNumbers();
            }


            lbl_result.Text = ComplexCalc.Multiply(C1, C2)?.Cartesian();
            txt_result2.Text = lbl_result.Text;

            if ((C1?.Real == 0 && C1?.Imag == 0) || (C2?.Real == 0 && C2?.Imag == 0))
                MessageBox.Show("Multiplikation nicht möglich");
            else if (lbl_result.Text == "")
                MessageBox.Show("Fehler bei der Eingabe");
        }

        private void btn_divide_Click(object sender, EventArgs e)
        {
            if (extended)
            {
                C1 = ComplexNumber.Input(txt_number1.Text);
                C2 = ComplexNumber.Input(txt_number2.Text);
            }
            else
            {
                setEasyComplexNumbers();
            }

            lbl_result.Text = ComplexCalc.Divide(C1, C2)?.Cartesian();
            txt_result2.Text = lbl_result.Text;

            if ((C1?.Real == 0 && C1?.Imag == 0) || (C2?.Real == 0 && C2?.Imag == 0))
                MessageBox.Show("Division nicht möglich");
            else if (lbl_result.Text == "")
                MessageBox.Show("Fehler bei der Eingabe");
        }

        private void btn_easyCalc_Click(object sender, EventArgs e)
        {
            if (btn_easyCalc.Text == "Normal")
            {
                pnl_calc.Visible = false;
                pnl_easyCalc.Visible = true;
                pnl_info.Visible = false;

                extended = false;
                btn_calc.Text = "Erweitert";
            }
        }


        
        private void setEasyComplexNumbers()
        {
            double dummy;
            double.TryParse(txt_Z1_Real.Text, out dummy);
            C1.Real = dummy;
            double.TryParse(txt_Z1_Imag.Text, out dummy);
            C1.Imag = dummy;
            C1.calcAbsolute();
            C1.calcPhi();

            double.TryParse(txt_Z2_Real.Text, out dummy);
            C2.Real = dummy;
            double.TryParse(txt_Z2_Imag.Text, out dummy);
            C2.Imag = dummy;
            C2.calcAbsolute();
            C2.calcPhi();
        }

        private void updatecombo()
        {
            cb_listcombo.Items.Clear();
            foreach (var item in listComplex)
            {
                cb_listcombo.Items.Add(item.Cartesian());
            }
        }
        int id = 0;
        private void btn_Save_Click(object sender, EventArgs e)
        {
            describeComplexNumber a;
            double dummy;
            if ( txt_Z1_Real.Text != "" && txt_Z1_Imag.Text != "")
            {
                a = new describeComplexNumber(id, "");
                double.TryParse(txt_Z1_Real.Text, out dummy);
                a.Real = dummy;
                double.TryParse(txt_Z1_Imag.Text, out dummy);
                a.Imag = dummy;

                a.calcPhi();
                a.calcAbsolute();
                id++;
                listComplex.Add(a);
            }
            if (txt_Z2_Real.Text != "" && txt_Z2_Imag.Text != "")
            {
                a = new describeComplexNumber(id, "");
                double.TryParse(txt_Z2_Real.Text, out dummy);
                a.Real = dummy;
                double.TryParse(txt_Z2_Imag.Text, out dummy);
                a.Imag = dummy;
                a.calcPhi();
                a.calcAbsolute();
                id++;
                listComplex.Add(a);
            }

            if (txt_result2.Text !="")
            {
                a = new describeComplexNumber(id, "");
                a.Real = ComplexNumber.Input(txt_result2.Text).Real;
                a.Imag = ComplexNumber.Input(txt_result2.Text).Imag;

                a.calcPhi();
                a.calcAbsolute();
                id++;
                listComplex.Add(a);
            }
            updatecombo();
        }


    }
}
