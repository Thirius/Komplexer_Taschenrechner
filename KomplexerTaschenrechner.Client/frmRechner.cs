using System;
using System.Collections.Generic;
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
    }
}
