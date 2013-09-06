﻿using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Input;
using DirkGentlyCalculator;


namespace Calculator
{
    public partial class Form1 : Form
    {
        private readonly DGCalculatorController _controller = new DGCalculatorController();
        public Form1()
        {
            InitializeComponent();
            _controller.AcceptCharacter('c');
            webBrowser1.DocumentText = _controller.GetOutput();
        }

        // I noticed that the same basic code was showing up in all of the methods:
        //      output.Text = _controller.AcceptCharacter('?')
        // Whenever I see duplicated code, I want to get rid of it -- it's more places where
        // errors can occur, more things I have to read over to find the "meat" of the code,
        // more stuff to modify and maintain if I want to make a change later.
        //
        // So, I wrote this "helper method" to encapsulate the redundant "boiler-plate" parts of
        // that code.  Now, each button-click handler just says 
        //      handleInput('?')"
        // and it's really easy to visually verify that each method does the intended thing.
        private void HandleInput(char input)
        {
            _controller.AcceptCharacter(input);
            webBrowser1.DocumentText = _controller.GetOutput();
        }

        // condensed button_click handler
        private void _buttonHolder_Click(object sender, EventArgs e)
        {
            Button sourceButton = (sender as Button);
            char buttonContent = Convert.ToChar(sourceButton.Tag);

            HandleInput(buttonContent);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _controller.Clear();
            
;
        }

        // keypress button handlers for operators
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57) // ASCII values for digits 0 - 9
            {
                HandleInput(e.KeyChar);
            }
            switch (e.KeyChar) // ASCII value for c,+,-,*,/,= operators
            {
                case (char)42: // multiplication symbol
                case (char)43: // addition symbol
                case (char)45: // subraction symbol
                case (char)47: // division symbol
                case (char)61: // equals symbol
                case (char)67: // 'C' for clear
                case (char)99: // 'c' for clear
                    HandleInput(e.KeyChar);
                    break;
            }
        }

        private void buttonCOS_Click(object sender, EventArgs e)
        {

        }

        private void buttonRed_Click(object sender, EventArgs e)
        {
            var n = new Random();
            DoIChing(n.Next(1, 9), n.Next(1, 9));
        }

        private void DoIChing(int throw1, int throw2)
        {
            _controller.Clear();
            webBrowser1.Navigate(string.Format("http://www.thateden.co.uk/dirk/pred.php?ching1={0}&ching2={1}", throw1,
                throw2));
        }

//        Inoperable attempt to trap Enter key press to model '=' keypress
//        private void output_KeyDown(object sender, KeyEventArgs e)
//        {
//            if (e.KeyValue == 13)
//            {
//                MessageBox.Show("Hey, you pressed the Enter key");
//                HandleInput('=');
//            }
//        }
    }
}
