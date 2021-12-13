using System;

namespace FactoryPattenExercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfWheels;
            bool input = false;
            do
            {
                Console.WriteLine("How many wheels would you like?");
            
                input = int.TryParse(Console.ReadLine(), out numberOfWheels);
            } while (input == false);

            var vehicle = VehicleFactory.GetVehicle(numberOfWheels);
            vehicle.Drive();
        
        }
    }
}
