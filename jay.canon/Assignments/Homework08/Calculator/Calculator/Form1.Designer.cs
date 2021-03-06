﻿using System.Windows.Forms;

namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.output = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonTimes = new System.Windows.Forms.Button();
            this.buttonDivide = new System.Windows.Forms.Button();
            this.buttonEquals = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // output
            // 
            this.output.Enabled = false;
            this.output.Location = new System.Drawing.Point(9, 9);
            this.output.Margin = new System.Windows.Forms.Padding(2);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(149, 20);
            this.output.TabIndex = 0;
            this.output.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 110);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this._buttonHolder_Click);
            this.button1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.TreatEnterAndEscAsNormalKeys);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(39, 110);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(26, 31);
            this.button2.TabIndex = 2;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this._buttonHolder_Click);
            this.button2.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.TreatEnterAndEscAsNormalKeys);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(69, 110);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(26, 31);
            this.button3.TabIndex = 3;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this._buttonHolder_Click);
            this.button3.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.TreatEnterAndEscAsNormalKeys);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(9, 76);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(26, 31);
            this.button4.TabIndex = 4;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this._buttonHolder_Click);
            this.button4.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.TreatEnterAndEscAsNormalKeys);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(39, 76);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(26, 31);
            this.button5.TabIndex = 5;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this._buttonHolder_Click);
            this.button5.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.TreatEnterAndEscAsNormalKeys);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(69, 76);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(26, 31);
            this.button6.TabIndex = 6;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this._buttonHolder_Click);
            this.button6.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.TreatEnterAndEscAsNormalKeys);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(9, 41);
            this.button7.Margin = new System.Windows.Forms.Padding(2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(26, 31);
            this.button7.TabIndex = 7;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this._buttonHolder_Click);
            this.button7.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.TreatEnterAndEscAsNormalKeys);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(39, 41);
            this.button8.Margin = new System.Windows.Forms.Padding(2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(26, 31);
            this.button8.TabIndex = 8;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this._buttonHolder_Click);
            this.button8.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.TreatEnterAndEscAsNormalKeys);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(69, 41);
            this.button9.Margin = new System.Windows.Forms.Padding(2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(26, 31);
            this.button9.TabIndex = 9;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this._buttonHolder_Click);
            this.button9.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.TreatEnterAndEscAsNormalKeys);
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(9, 144);
            this.button0.Margin = new System.Windows.Forms.Padding(2);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(26, 31);
            this.button0.TabIndex = 10;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this._buttonHolder_Click);
            this.button0.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.TreatEnterAndEscAsNormalKeys);
            // 
            // buttonPlus
            // 
            this.buttonPlus.Location = new System.Drawing.Point(40, 144);
            this.buttonPlus.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(88, 31);
            this.buttonPlus.TabIndex = 11;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this._buttonHolder_Click);
            this.buttonPlus.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.TreatEnterAndEscAsNormalKeys);
            // 
            // buttonMinus
            // 
            this.buttonMinus.Location = new System.Drawing.Point(103, 110);
            this.buttonMinus.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(26, 31);
            this.buttonMinus.TabIndex = 12;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this._buttonHolder_Click);
            this.buttonMinus.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.TreatEnterAndEscAsNormalKeys);
            // 
            // buttonTimes
            // 
            this.buttonTimes.Location = new System.Drawing.Point(103, 76);
            this.buttonTimes.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTimes.Name = "buttonTimes";
            this.buttonTimes.Size = new System.Drawing.Size(26, 31);
            this.buttonTimes.TabIndex = 13;
            this.buttonTimes.Text = "*";
            this.buttonTimes.UseVisualStyleBackColor = true;
            this.buttonTimes.Click += new System.EventHandler(this._buttonHolder_Click);
            this.buttonTimes.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.TreatEnterAndEscAsNormalKeys);
            // 
            // buttonDivide
            // 
            this.buttonDivide.Location = new System.Drawing.Point(103, 41);
            this.buttonDivide.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDivide.Name = "buttonDivide";
            this.buttonDivide.Size = new System.Drawing.Size(26, 31);
            this.buttonDivide.TabIndex = 14;
            this.buttonDivide.Text = "/";
            this.buttonDivide.UseVisualStyleBackColor = true;
            this.buttonDivide.Click += new System.EventHandler(this._buttonHolder_Click);
            this.buttonDivide.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.TreatEnterAndEscAsNormalKeys);
            // 
            // buttonEquals
            // 
            this.buttonEquals.Location = new System.Drawing.Point(132, 75);
            this.buttonEquals.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEquals.Name = "buttonEquals";
            this.buttonEquals.Size = new System.Drawing.Size(25, 100);
            this.buttonEquals.TabIndex = 15;
            this.buttonEquals.Text = "=";
            this.buttonEquals.UseVisualStyleBackColor = true;
            this.buttonEquals.Click += new System.EventHandler(this._buttonHolder_Click);
            this.buttonEquals.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.TreatEnterAndEscAsNormalKeys);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(132, 41);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(26, 31);
            this.buttonClear.TabIndex = 16;
            this.buttonClear.Text = "c";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this._buttonHolder_Click);
            this.buttonClear.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.TreatEnterAndEscAsNormalKeys);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(170, 187);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonEquals);
            this.Controls.Add(this.buttonDivide);
            this.Controls.Add(this.buttonTimes);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.output);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonTimes;
        private System.Windows.Forms.Button buttonDivide;
        private System.Windows.Forms.Button buttonEquals;
        private System.Windows.Forms.Button buttonClear;
        
    }
}

