﻿using System;
using NUnit.Framework;
using Calculator;

namespace CalculatorControllerTests
{
    class ControlsTests
    {
        // This CalculatorController instance will be created before any test is run, and will be used by each test in turn.
        private readonly CalculatorController _controller = new CalculatorController();

        // The method that is marked with the [SetUp] annotation is run before each test is run.
        // In this case, its purpose is to call Clear() on the CalculatorController so that each test starts with a clean slate.
        [SetUp]
        public void BeforeEachTest()
        {
            _controller.Clear();
        }

        [Test]
        public void CanClearOutput()
        {
            _controller.AcceptCharacter('C');
            Assert.That(_controller.GetOutput(), Is.Empty);
        }

        [Test]
        public void CanEnterOperators()
        {
            const string operators = "+-*/";
            foreach (char @operator in operators)
            {
                Assert.That(_controller.AcceptCharacter(@operator), Is.EqualTo(@operator.ToString()));
            }
        }
    }
}
