using System;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;

namespace TransportApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Transportation trans = new Transportation("vroom", 4);
            Cars  car  = new Cars();
            Boats boat = new Boats();
            Trains train = new Trains("string", 7);

            Console.WriteLine($"Boat has {boat.numOfWheels} wheels,\nThe car has {car.numOfDoors} doors,\nThe boat is {boat.color},\nThe train uses a(n) {train.engineType} engine.");
            Console.WriteLine($"The train is {train.color} and has {train.numOfWheels} wheels.");


        }
    }
}
