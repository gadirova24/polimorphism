using System;
namespace Abstract_Interface1
{
    internal class Calculator : IAdd, IDiff, IMultiply, IDivide
    {
        public decimal Add(decimal num1, decimal num2)
            => num1 + num2;

        public decimal Difference(decimal num1, decimal num2)
        {
            return num1 - num2;
        }

        public decimal Divide(decimal num1, decimal num2)
        {
            return num1 / num2;
        }

        public decimal Multiply(decimal num1, decimal num2)
        {
            return num1 * num2;
        }
    }
}

