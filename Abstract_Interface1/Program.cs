#region Practice

//Cat garflied = new Cat();
//Shark balaeli = new Shark();
//Parrot par = new Parrot();
//Chicken kfc = new Chicken();
//Dog spike = new Dog();
//Animal[] animals = { garflied, balaeli, par };

//foreach (Animal animal in animals)
//{
//    animal.Eat();
//}
//ISwim[] swimmers = { spike, balaeli };

//foreach (var animal in swimmers)
//{
//    animal.Swim();
//}
//ISwim it = new Dog();
//it.Test();
//garflied.Eat();

//Bird[] birds = {par, kfc};
//foreach (var bird in birds)
//{
//    bird.Fly();
//}





//using Abstract_Interface1;

//Vehicle[] vehicles =
//{
//    new Car()
//    {
//        Color = "red",
//        DoorCount = 2,
//        DrivePath = 4000,
//        DriveTime = 352,
//        FactoryName = "BMW",
//        Model = "F30",
//        IsElectricCar = false
//    },
//    new Bicycle
//    {
//        Color = "white",
//        DriveTime = 500,
//        Model = "Track",
//        FactoryName = "BMX",
//        DrivePath = 2000,
//        WheelCount = 2
//    }
//};
//foreach (var vehicle in vehicles)
//{
//    Console.WriteLine(vehicle.ToString() + " " + Math.Round(vehicle.AverageSpeed(), 1));
//    //vehicle.DefineNatureHarmness();
//}


#endregion

#region Homework

//using Abstract_Interface1;
//Console.WriteLine("Menu:");
//Console.WriteLine("1.Square");
//Console.WriteLine("2.Rectangular");
//Console.WriteLine("Choose");
//int choice;
//if (int.TryParse(Console.ReadLine(), out choice))
//{
//    switch (choice)
//    {
//        case 1:
//            Square square = new Square();
//            Console.WriteLine("Add side: ");
//            if (double.TryParse(Console.ReadLine(), out double side))
//            {
//                square.Side = side;
//                Console.WriteLine($"Figure: {square.CalcArea()}");
//            }
//            else
//            {
//                Console.WriteLine("Choose correct side.");
//            }
//            break;

//        case 2:

//            Rectangular rectangular = new Rectangular();
//            Console.WriteLine("Add width :");
//            if (double.TryParse(Console.ReadLine(), out double width))
//            {
//                Console.WriteLine("Add length: ");
//                if (double.TryParse(Console.ReadLine(), out double length))
//                {
//                    rectangular.Width = width;
//                    rectangular.Length = length;
//                    Console.WriteLine($"Figure: {rectangular.CalcArea()}");
//                }
//                else
//                {
//                    Console.WriteLine("Choose correct length");
//                }
//            }
//            else
//            {
//                Console.WriteLine("Choose correct width");
//            }
//            break;

//        case 0:
//            Console.WriteLine(" Error");
//            break;
//    }

//}




#endregion