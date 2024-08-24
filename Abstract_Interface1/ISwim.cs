using System;
namespace Abstract_Interface1
{
    public interface ISwim
    {
        int MaxSwimTime { get; }
        void Swim();
        void Test()
        {
            Console.WriteLine("Test");
        }
    }
}

