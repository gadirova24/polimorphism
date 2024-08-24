using System;
namespace Abstract_Interface1
{
    public class Rectangular : Figure
    {
        private double width;
        private double length;


        public double Width
        {
            get
            {
                return width;
            }
            set
            {
                if (value > 0)
                {
                    width = value;
                }
            }
        }

        public double Length
        {
            get
            {
                return length;
            }
            set
            {
                if (value > 0)
                {
                    length = value;
                }
            }
        }

        public override double CalcArea()
        {
            return width * length;
        }
    }
}

