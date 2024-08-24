using System;
namespace Abstract_Interface1
{
    public class Bicycle : Vehicle
    {
        public int WheelCount { get; set; }
        public override void DefineNatureHarmness()
        {
            Console.WriteLine("None");
        }
        public override string GetInfo()
        {
            return base.GetInfo() + " " + WheelCount;
        }
    }
}

