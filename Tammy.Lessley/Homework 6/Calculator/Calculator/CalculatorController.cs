﻿using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Calculator
{
    // NOTE: this class has to be marked with "public" so that it is visible to the CalculatorControllerTests project.
    public class CalculatorController
    {
        //private int _currentValue ;
        //private string _currentStringValue = string.Empty;
        //private int _LastValue;
        private double _currentValue;
        private double _previousValue;
        private bool OperatorAdd;
        private bool OperatorSubtract;
        private bool OperatorMultiply;
        private bool OperatorDivide;

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
                OperatorAdd = true;
            }
            else if (input == '-')
            {
                _previousValue = _currentValue;
                _currentValue = 0;
                OperatorAdd = true;
            }
            else if (input == '*')
            {
                _previousValue = _currentValue;
                _currentValue = 0;
                OperatorAdd = true;
            }
            else if (input == '/')
            {
                _previousValue = _currentValue;
                _currentValue = 0;
                OperatorAdd = true;
            }
            else
            {
                _currentValue = _currentValue*10 + int.Parse(input.ToString());
            }
        }


        //ignore leading zeros... if the first digit is zero... if the sum of the first N digits is zero... disregard, else currentvalue...


        // Your code will eventually go here, to make all of the tests pass.

        // DO NOT WRITE THIS CODE YET!  WRITING THIS CODE WILL BE HOMEWORK 5!


        // Someday, this method will return the string that should be displayed in the "output window" of the 
        // calculator.  For now, it just returns a dummy value of "13", since the compiler requires that it
        // return something.
        public string GetOutput()
            //{
            //    if (_currentStringValue == string.Empty)
            //    {
            //        return "0";
            //    }
            //    return _currentStringValue;
            //}
            //{           return _currentValue.ToString();}

            //}
        {
            //if (sizeof(_currentValue) == "")
            //{
            //    return null;
            //}
            ;
            if (Math.Floor(Math.Log10(_currentValue) + 1) > 16)
            {
                return _currentValue.ToString().Substring(0, 16);
            }
            return _currentValue.ToString();
        }
    }
}
