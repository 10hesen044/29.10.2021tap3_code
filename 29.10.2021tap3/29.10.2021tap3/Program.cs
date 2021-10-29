using System;

namespace _29._10._2021tap3
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle();

            vehicle.Name = "Car";
            vehicle.Color = "Black";

            Console.WriteLine($"{vehicle.Name} {vehicle.Color}");


            Car car = new Car();
            car.Name = "Car";
            car.Color = "Black";
            car.Brand = "Lexus";
            car.Model = "LX 470";

            Console.WriteLine($"{car.Brand} {car.Model} {car.Name} {car.Color}");


            Car car2 = new Car();
            car2.Name = "Bus";
            car2.Color = "White";
            car2.Brand = "Ford";
            car2.Model = "Transit";

            Console.WriteLine($"{car2.Brand} {car2.Model} {car2.Name} {car2.Color}");
        }
    }
}
