using System;
namespace Abstract_Interface1
{
    public class Car : Vehicle
    {
        public int DoorCount { get; set; }
        public bool IsElectricCar { get; set; }
        public override void DefineNatureHarmness()
        {
            if (IsElectricCar)
            {
                Console.WriteLine("Low");
            }
            Console.WriteLine("High");
        }
        public override string GetInfo()
        {
            return base.GetInfo() + $" {DoorCount} {IsElectricCar}";
        }
    }
}

