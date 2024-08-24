using System;
namespace Abstract_Interface1
{
    public abstract class Vehicle
    {
        public string FactoryName { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public float DriveTime { get; set; }
        public float DrivePath { get; set; }
        public float AverageSpeed()
        {
            return DrivePath / DriveTime;
        }
        public virtual string GetInfo()
        {
            return $"{FactoryName} {Model} {Color} {DriveTime} {DrivePath}";
        }
        public override string ToString()
        {
            return $"{FactoryName} {Model}";
        }

        public abstract void DefineNatureHarmness();
    }
}

