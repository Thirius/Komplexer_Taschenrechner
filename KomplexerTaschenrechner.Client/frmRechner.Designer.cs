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
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.pnl_btnsHeader = new System.Windows.Forms.Panel();
            this.btn_Min = new System.Windows.Forms.Button();
            this.Btn_Close = new System.Windows.Forms.Button();
            this.btn_addition = new System.Windows.Forms.Button();
            this.btn_subtract = new System.Windows.Forms.Button();
            this.btn_multiply = new System.Windows.Forms.Button();
            this.btn_divide = new System.Windows.Forms.Button();
            this.btn_detail = new System.Windows.Forms.Button();
            this.txt_complex = new System.Windows.Forms.TextBox();
            this.lbl_Z = new System.Windows.Forms.Label();
            this.pnl_Header.SuspendLayout();
            this.pnl_btnsHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Header
            // 
            this.pnl_Header.BackColor = System.Drawing.Color.RoyalBlue;
            this.pnl_Header.Controls.Add(this.lbl_Title);
            this.pnl_Header.Controls.Add(this.pnl_btnsHeader);
            this.pnl_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Header.Location = new System.Drawing.Point(0, 0);
            this.pnl_Header.Margin = new System.Windows.Forms.Padding(4);
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
            this.pnl_btnsHeader.Margin = new System.Windows.Forms.Padding(4);
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
            this.btn_Min.Margin = new System.Windows.Forms.Padding(4);
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
            this.Btn_Close.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(40, 42);
            this.Btn_Close.TabIndex = 0;
            this.Btn_Close.Text = "X";
            this.Btn_Close.UseVisualStyleBackColor = true;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // btn_addition
            // 
            this.btn_addition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addition.Location = new System.Drawing.Point(12, 159);
            this.btn_addition.Name = "btn_addition";
            this.btn_addition.Size = new System.Drawing.Size(665, 31);
            this.btn_addition.TabIndex = 26;
            this.btn_addition.Text = "Addieren";
            this.btn_addition.UseVisualStyleBackColor = true;
            // 
            // btn_subtract
            // 
            this.btn_subtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_subtract.Location = new System.Drawing.Point(12, 196);
            this.btn_subtract.Name = "btn_subtract";
            this.btn_subtract.Size = new System.Drawing.Size(665, 31);
            this.btn_subtract.TabIndex = 27;
            this.btn_subtract.Text = "Subtrahieren";
            this.btn_subtract.UseVisualStyleBackColor = true;
            // 
            // btn_multiply
            // 
            this.btn_multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_multiply.Location = new System.Drawing.Point(12, 233);
            this.btn_multiply.Name = "btn_multiply";
            this.btn_multiply.Size = new System.Drawing.Size(665, 31);
            this.btn_multiply.TabIndex = 28;
            this.btn_multiply.Text = "Multiplizieren";
            this.btn_multiply.UseVisualStyleBackColor = true;
            // 
            // btn_divide
            // 
            this.btn_divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_divide.Location = new System.Drawing.Point(12, 270);
            this.btn_divide.Name = "btn_divide";
            this.btn_divide.Size = new System.Drawing.Size(665, 31);
            this.btn_divide.TabIndex = 29;
            this.btn_divide.Text = "Dividieren";
            this.btn_divide.UseVisualStyleBackColor = true;
            // 
            // btn_detail
            // 
            this.btn_detail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_detail.Location = new System.Drawing.Point(12, 122);
            this.btn_detail.Name = "btn_detail";
            this.btn_detail.Size = new System.Drawing.Size(665, 31);
            this.btn_detail.TabIndex = 30;
            this.btn_detail.Text = "Details";
            this.btn_detail.UseVisualStyleBackColor = true;
            // 
            // txt_complex
            // 
            this.txt_complex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_complex.Location = new System.Drawing.Point(97, 72);
            this.txt_complex.Margin = new System.Windows.Forms.Padding(4);
            this.txt_complex.Name = "txt_complex";
            this.txt_complex.Size = new System.Drawing.Size(580, 30);
            this.txt_complex.TabIndex = 11;
            this.txt_complex.TextChanged += new System.EventHandler(this.txt_complex_TextChanged);
            this.txt_complex.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Calc_KeyPress);
            // 
            // lbl_Z
            // 
            this.lbl_Z.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Z.Location = new System.Drawing.Point(6, 71);
            this.lbl_Z.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Z.Name = "lbl_Z";
            this.lbl_Z.Size = new System.Drawing.Size(83, 31);
            this.lbl_Z.TabIndex = 12;
            this.lbl_Z.Text = "Z =";
            this.lbl_Z.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Calc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 522);
            this.Controls.Add(this.btn_detail);
            this.Controls.Add(this.txt_complex);
            this.Controls.Add(this.btn_divide);
            this.Controls.Add(this.lbl_Z);
            this.Controls.Add(this.btn_multiply);
            this.Controls.Add(this.btn_subtract);
            this.Controls.Add(this.btn_addition);
            this.Controls.Add(this.pnl_Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(693, 522);
            this.Name = "Calc";
            this.Text = "Taschenrechner";
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            this.pnl_btnsHeader.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Panel pnl_btnsHeader;
        private System.Windows.Forms.Button btn_Min;
        private System.Windows.Forms.Button Btn_Close;
        private System.Windows.Forms.Button btn_addition;
        private System.Windows.Forms.Button btn_subtract;
        private System.Windows.Forms.Button btn_multiply;
        private System.Windows.Forms.Button btn_divide;
        private System.Windows.Forms.Button btn_detail;
        private System.Windows.Forms.TextBox txt_complex;
        private System.Windows.Forms.Label lbl_Z;
    }
}
