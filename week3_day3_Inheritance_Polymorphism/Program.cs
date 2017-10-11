using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3_day3_Inheritance_Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            vehicle baseVehicle = new vehicle(4, 2000, "Black", 55d);
            baseVehicle.Move();
            Console.WriteLine(baseVehicle.DistanceTraveled);
        }
    }
}
