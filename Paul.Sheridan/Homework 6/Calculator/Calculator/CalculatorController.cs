﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Calculator
{
    // NOTE: this class has to be marked with "public" so that it is visible to the CalculatorControllerTests project.
    public class CalculatorController
    {
        private int _currentValue;
        private int _previousValue;
        private string Operator;


        // This method is the core method of CalculatorController.  In Homework 5, when you are making
        // the tests we co-create in Homework 4 pass, you'll write code in this method (and probably in
        // helper methods that it calls) to make the calculator behave according to the tests.

        public void AcceptCharacter(char input)
        {
            if (input == 'c')
            {
                _currentValue = 0;
            }
            else if (input == '+')
            {
                _previousValue = _currentValue;
                _currentValue = 0;
                Operator = "+";
            }
            else if (input == '-')
            {
                _previousValue = _currentValue;
                _currentValue = 0;
                Operator = "-";
            }
            else if (input == '*')
            {
                _previousValue = _currentValue;
                _currentValue = 0;
                Operator = "*";
            }
            else if (input == '/')
            {
                _previousValue = _currentValue;
                _currentValue = 0;
                Operator = "/";
            }
            else if (input == '=')
            {

            }
            else
            {
                _currentValue = _currentValue*10 + int.Parse(input.ToString());
            }
        }


        public string GetOutput()
        {
            return _currentValue.ToString();
        }
    }
}
