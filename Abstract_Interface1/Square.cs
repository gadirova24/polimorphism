using System;
namespace Abstract_Interface1
{
    public class Square : Figure
    {
        private double side;
        public double Side
        {
            get
            {
                return side;
            }
            set
            {
                if (value > 0)
                {
                    side = value;
                }
            }
        }

        public override double CalcArea()
        {
            return side * side;
        }
    }
}

