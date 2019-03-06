﻿namespace KomplexerTaschenrechner.Client
{
    partial class Calc
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.pnl_btnsHeader = new System.Windows.Forms.Panel();
            this.btn_Min = new System.Windows.Forms.Button();
            this.Btn_Close = new System.Windows.Forms.Button();
            this.txt_complex = new System.Windows.Forms.TextBox();
            this.lbl_Z = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_expo = new System.Windows.Forms.Label();
            this.lbl_cartesian = new System.Windows.Forms.Label();
            this.lbl_polar = new System.Windows.Forms.Label();
            this.lbl_exponential = new System.Windows.Forms.Label();
            this.lbl_absolute = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_phi = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_conjugate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnl_info = new System.Windows.Forms.Panel();
            this.btn_info = new System.Windows.Forms.Button();
            this.btn_calc = new System.Windows.Forms.Button();
            this.pnl_calc = new System.Windows.Forms.Panel();
            this.lbl_result = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_subtract = new System.Windows.Forms.Button();
            this.btn_multiply = new System.Windows.Forms.Button();
            this.btn_divide = new System.Windows.Forms.Button();
            this.txt_number2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_number1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tip = new System.Windows.Forms.ToolTip(this.components);
            this.pnl_Header.SuspendLayout();
            this.pnl_btnsHeader.SuspendLayout();
            this.pnl_info.SuspendLayout();
            this.pnl_calc.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Header
            // 
            this.pnl_Header.BackColor = System.Drawing.Color.RoyalBlue;
            this.pnl_Header.Controls.Add(this.lbl_Title);
            this.pnl_Header.Controls.Add(this.pnl_btnsHeader);
            this.pnl_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Header.Location = new System.Drawing.Point(0, 0);
            this.pnl_Header.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_Header.MinimumSize = new System.Drawing.Size(588, 42);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(693, 42);
            this.pnl_Header.TabIndex = 0;
            this.pnl_Header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownEvent);
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(4, 4);
            this.lbl_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(117, 31);
            this.lbl_Title.TabIndex = 1;
            this.lbl_Title.Text = "Rechner";
            this.lbl_Title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownEvent);
            // 
            // pnl_btnsHeader
            // 
            this.pnl_btnsHeader.Controls.Add(this.btn_Min);
            this.pnl_btnsHeader.Controls.Add(this.Btn_Close);
            this.pnl_btnsHeader.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_btnsHeader.Location = new System.Drawing.Point(608, 0);
            this.pnl_btnsHeader.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_btnsHeader.Name = "pnl_btnsHeader";
            this.pnl_btnsHeader.Size = new System.Drawing.Size(85, 42);
            this.pnl_btnsHeader.TabIndex = 0;
            // 
            // btn_Min
            // 
            this.btn_Min.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Min.FlatAppearance.BorderSize = 0;
            this.btn_Min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Min.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Min.Location = new System.Drawing.Point(0, 0);
            this.btn_Min.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Min.Name = "btn_Min";
            this.btn_Min.Size = new System.Drawing.Size(45, 42);
            this.btn_Min.TabIndex = 1;
            this.btn_Min.Text = "_";
            this.btn_Min.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Min.UseVisualStyleBackColor = true;
            this.btn_Min.Click += new System.EventHandler(this.btn_Min_Click);
            // 
            // Btn_Close
            // 
            this.Btn_Close.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_Close.FlatAppearance.BorderSize = 0;
            this.Btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Close.Location = new System.Drawing.Point(45, 0);
            this.Btn_Close.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(40, 42);
            this.Btn_Close.TabIndex = 0;
            this.Btn_Close.Text = "X";
            this.Btn_Close.UseVisualStyleBackColor = true;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // txt_complex
            // 
            this.txt_complex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_complex.Location = new System.Drawing.Point(60, 22);
            this.txt_complex.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_complex.Name = "txt_complex";
            this.txt_complex.Size = new System.Drawing.Size(615, 30);
            this.txt_complex.TabIndex = 11;
            this.txt_complex.TextChanged += new System.EventHandler(this.txt_complex_TextChanged);
            this.txt_complex.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Calc_KeyPress);
            // 
            // lbl_Z
            // 
            this.lbl_Z.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Z.Location = new System.Drawing.Point(12, 21);
            this.lbl_Z.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Z.Name = "lbl_Z";
            this.lbl_Z.Size = new System.Drawing.Size(48, 31);
            this.lbl_Z.TabIndex = 12;
            this.lbl_Z.Text = "Z =";
            this.lbl_Z.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 31);
            this.label1.TabIndex = 13;
            this.label1.Text = "Kartesisch =";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 31);
            this.label2.TabIndex = 14;
            this.label2.Text = "Polar =";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_expo
            // 
            this.lbl_expo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_expo.Location = new System.Drawing.Point(12, 162);
            this.lbl_expo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_expo.Name = "lbl_expo";
            this.lbl_expo.Size = new System.Drawing.Size(146, 31);
            this.lbl_expo.TabIndex = 15;
            this.lbl_expo.Text = "Exponential =";
            this.lbl_expo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_cartesian
            // 
            this.lbl_cartesian.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cartesian.Location = new System.Drawing.Point(163, 70);
            this.lbl_cartesian.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_cartesian.Name = "lbl_cartesian";
            this.lbl_cartesian.Size = new System.Drawing.Size(513, 31);
            this.lbl_cartesian.TabIndex = 16;
            this.lbl_cartesian.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_polar
            // 
            this.lbl_polar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_polar.Location = new System.Drawing.Point(162, 132);
            this.lbl_polar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_polar.Name = "lbl_polar";
            this.lbl_polar.Size = new System.Drawing.Size(513, 31);
            this.lbl_polar.TabIndex = 17;
            this.lbl_polar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_exponential
            // 
            this.lbl_exponential.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_exponential.Location = new System.Drawing.Point(162, 162);
            this.lbl_exponential.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_exponential.Name = "lbl_exponential";
            this.lbl_exponential.Size = new System.Drawing.Size(513, 31);
            this.lbl_exponential.TabIndex = 18;
            this.lbl_exponential.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_absolute
            // 
            this.lbl_absolute.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_absolute.Location = new System.Drawing.Point(162, 194);
            this.lbl_absolute.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_absolute.Name = "lbl_absolute";
            this.lbl_absolute.Size = new System.Drawing.Size(513, 31);
            this.lbl_absolute.TabIndex = 20;
            this.lbl_absolute.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 194);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 31);
            this.label4.TabIndex = 19;
            this.label4.Text = "Betrag =";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_phi
            // 
            this.lbl_phi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_phi.Location = new System.Drawing.Point(164, 227);
            this.lbl_phi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_phi.Name = "lbl_phi";
            this.lbl_phi.Size = new System.Drawing.Size(513, 31);
            this.lbl_phi.TabIndex = 22;
            this.lbl_phi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 227);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 31);
            this.label6.TabIndex = 21;
            this.label6.Text = "Phi =";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_conjugate
            // 
            this.lbl_conjugate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_conjugate.Location = new System.Drawing.Point(163, 102);
            this.lbl_conjugate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_conjugate.Name = "lbl_conjugate";
            this.lbl_conjugate.Size = new System.Drawing.Size(513, 31);
            this.lbl_conjugate.TabIndex = 24;
            this.lbl_conjugate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 102);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 31);
            this.label5.TabIndex = 23;
            this.label5.Text = "Konjugiert =";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnl_info
            // 
            this.pnl_info.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_info.Controls.Add(this.lbl_exponential);
            this.pnl_info.Controls.Add(this.lbl_conjugate);
            this.pnl_info.Controls.Add(this.label1);
            this.pnl_info.Controls.Add(this.txt_complex);
            this.pnl_info.Controls.Add(this.lbl_Z);
            this.pnl_info.Controls.Add(this.label5);
            this.pnl_info.Controls.Add(this.label2);
            this.pnl_info.Controls.Add(this.lbl_phi);
            this.pnl_info.Controls.Add(this.lbl_expo);
            this.pnl_info.Controls.Add(this.label6);
            this.pnl_info.Controls.Add(this.lbl_cartesian);
            this.pnl_info.Controls.Add(this.lbl_absolute);
            this.pnl_info.Controls.Add(this.lbl_polar);
            this.pnl_info.Controls.Add(this.label4);
            this.pnl_info.Location = new System.Drawing.Point(0, 36);
            this.pnl_info.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_info.Name = "pnl_info";
            this.pnl_info.Size = new System.Drawing.Size(693, 280);
            this.pnl_info.TabIndex = 25;
            // 
            // btn_info
            // 
            this.btn_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_info.Location = new System.Drawing.Point(16, 331);
            this.btn_info.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_info.Name = "btn_info";
            this.btn_info.Size = new System.Drawing.Size(170, 40);
            this.btn_info.TabIndex = 26;
            this.btn_info.Text = "Info";
            this.btn_info.UseVisualStyleBackColor = true;
            this.btn_info.Click += new System.EventHandler(this.btn_info_Click);
            // 
            // btn_calc
            // 
            this.btn_calc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calc.Location = new System.Drawing.Point(505, 331);
            this.btn_calc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(170, 40);
            this.btn_calc.TabIndex = 27;
            this.btn_calc.Text = "Berechnung";
            this.btn_calc.UseVisualStyleBackColor = true;
            this.btn_calc.Click += new System.EventHandler(this.btn_calc_Click);
            // 
            // pnl_calc
            // 
            this.pnl_calc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_calc.Controls.Add(this.lbl_result);
            this.pnl_calc.Controls.Add(this.label8);
            this.pnl_calc.Controls.Add(this.btn_add);
            this.pnl_calc.Controls.Add(this.btn_subtract);
            this.pnl_calc.Controls.Add(this.btn_multiply);
            this.pnl_calc.Controls.Add(this.btn_divide);
            this.pnl_calc.Controls.Add(this.txt_number2);
            this.pnl_calc.Controls.Add(this.label3);
            this.pnl_calc.Controls.Add(this.txt_number1);
            this.pnl_calc.Controls.Add(this.label9);
            this.pnl_calc.Location = new System.Drawing.Point(0, 36);
            this.pnl_calc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_calc.Name = "pnl_calc";
            this.pnl_calc.Size = new System.Drawing.Size(693, 280);
            this.pnl_calc.TabIndex = 26;
            // 
            // lbl_result
            // 
            this.lbl_result.BackColor = System.Drawing.Color.White;
            this.lbl_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_result.Location = new System.Drawing.Point(132, 163);
            this.lbl_result.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(543, 31);
            this.lbl_result.TabIndex = 34;
            this.lbl_result.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(0, 163);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 31);
            this.label8.TabIndex = 33;
            this.label8.Text = "Ergebnis =";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(60, 102);
            this.btn_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(141, 40);
            this.btn_add.TabIndex = 32;
            this.btn_add.Text = "+";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_subtract
            // 
            this.btn_subtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_subtract.Location = new System.Drawing.Point(215, 102);
            this.btn_subtract.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_subtract.Name = "btn_subtract";
            this.btn_subtract.Size = new System.Drawing.Size(141, 40);
            this.btn_subtract.TabIndex = 31;
            this.btn_subtract.Text = "-";
            this.btn_subtract.UseVisualStyleBackColor = true;
            this.btn_subtract.Click += new System.EventHandler(this.btn_subtract_Click);
            // 
            // btn_multiply
            // 
            this.btn_multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_multiply.Location = new System.Drawing.Point(372, 102);
            this.btn_multiply.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_multiply.Name = "btn_multiply";
            this.btn_multiply.Size = new System.Drawing.Size(141, 40);
            this.btn_multiply.TabIndex = 30;
            this.btn_multiply.Text = "×";
            this.btn_multiply.UseVisualStyleBackColor = true;
            this.btn_multiply.Click += new System.EventHandler(this.btn_multiply_Click);
            // 
            // btn_divide
            // 
            this.btn_divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_divide.Location = new System.Drawing.Point(533, 102);
            this.btn_divide.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_divide.Name = "btn_divide";
            this.btn_divide.Size = new System.Drawing.Size(141, 40);
            this.btn_divide.TabIndex = 29;
            this.btn_divide.Text = "÷";
            this.btn_divide.UseVisualStyleBackColor = true;
            this.btn_divide.Click += new System.EventHandler(this.btn_divide_Click);
            // 
            // txt_number2
            // 
            this.txt_number2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_number2.Location = new System.Drawing.Point(60, 61);
            this.txt_number2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_number2.Name = "txt_number2";
            this.txt_number2.Size = new System.Drawing.Size(615, 30);
            this.txt_number2.TabIndex = 13;
            this.txt_number2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Calc_KeyPress);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 31);
            this.label3.TabIndex = 14;
            this.label3.Text = "Z2 =";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_number1
            // 
            this.txt_number1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_number1.Location = new System.Drawing.Point(60, 22);
            this.txt_number1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_number1.Name = "txt_number1";
            this.txt_number1.Size = new System.Drawing.Size(615, 30);
            this.txt_number1.TabIndex = 11;
            this.txt_number1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Calc_KeyPress);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 21);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 31);
            this.label9.TabIndex = 12;
            this.label9.Text = "Z =";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tip
            // 
            this.tip.ToolTipTitle = "Eingabe Format";
            // 
            // Calc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 384);
            this.Controls.Add(this.pnl_Header);
            this.Controls.Add(this.pnl_calc);
            this.Controls.Add(this.btn_calc);
            this.Controls.Add(this.btn_info);
            this.Controls.Add(this.pnl_info);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(693, 384);
            this.Name = "Calc";
            this.Text = "Taschenrechner";
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            this.pnl_btnsHeader.ResumeLayout(false);
            this.pnl_info.ResumeLayout(false);
            this.pnl_info.PerformLayout();
            this.pnl_calc.ResumeLayout(false);
            this.pnl_calc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Panel pnl_btnsHeader;
        private System.Windows.Forms.Button btn_Min;
        private System.Windows.Forms.Button Btn_Close;
        private System.Windows.Forms.TextBox txt_complex;
        private System.Windows.Forms.Label lbl_Z;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_expo;
        private System.Windows.Forms.Label lbl_cartesian;
        private System.Windows.Forms.Label lbl_polar;
        private System.Windows.Forms.Label lbl_exponential;
        private System.Windows.Forms.Label lbl_absolute;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_phi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_conjugate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnl_info;
        private System.Windows.Forms.Button btn_info;
        private System.Windows.Forms.Button btn_calc;
        private System.Windows.Forms.Panel pnl_calc;
        private System.Windows.Forms.Label lbl_result;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_subtract;
        private System.Windows.Forms.Button btn_multiply;
        private System.Windows.Forms.Button btn_divide;
        private System.Windows.Forms.TextBox txt_number2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_number1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolTip tip;
    }
}

