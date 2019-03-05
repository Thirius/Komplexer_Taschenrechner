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

        private void tc_Calc_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Ausgabe();
        }

        ComplexNumber cN;

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
            if (pnl_info.Visible)
                return;

            pnl_calc.Visible = false;

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
            if (pnl_calc.Visible)
                return;

            pnl_info.Visible = false;

            if (txt_complex.Text != "")
                txt_number1.Text = txt_complex.Text;

            txt_complex.Text = "";
            pnl_calc.Visible = true;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            ComplexNumber C1 = ComplexNumber.Input(txt_number1.Text);
            ComplexNumber C2 = ComplexNumber.Input(txt_number2.Text);
            
            lbl_result.Text = ComplexCalc.Add(C1, C2)?.Cartesian();
            if (lbl_result.Text == "")
                MessageBox.Show("Fehler bei der Eingabe");
        }

        private void btn_subtract_Click(object sender, EventArgs e)
        {
            ComplexNumber C1 = ComplexNumber.Input(txt_number1.Text);
            ComplexNumber C2 = ComplexNumber.Input(txt_number2.Text);

            lbl_result.Text = ComplexCalc.Subtract(C1, C2)?.Cartesian();
            if (lbl_result.Text == "")
                MessageBox.Show("Fehler bei der Eingabe");
        }

        private void btn_multiply_Click(object sender, EventArgs e)
        {
            ComplexNumber C1 = ComplexNumber.Input(txt_number1.Text);
            ComplexNumber C2 = ComplexNumber.Input(txt_number2.Text);

            lbl_result.Text = ComplexCalc.Multiply(C1, C2)?.Cartesian();
            if(lbl_result.Text == "")
                MessageBox.Show("Fehler bei der Eingabe");
        }

        private void btn_divide_Click(object sender, EventArgs e)
        {
            ComplexNumber C1 = ComplexNumber.Input(txt_number1.Text);
            ComplexNumber C2 = ComplexNumber.Input(txt_number2.Text);

            lbl_result.Text = ComplexCalc.Divide(C1, C2)?.Cartesian();
            if (lbl_result.Text == "")
                MessageBox.Show("Fehler bei der Eingabe");
        }
    }
}
