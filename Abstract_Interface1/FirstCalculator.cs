﻿using System;
namespace Abstract_Interface1
{

    internal class FirstCalculator : IAdd, IMultiply
    {
        public decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }

        public decimal Multiply(decimal num1, decimal num2)
        {
            return num1 * num2;
        }
    }
}

