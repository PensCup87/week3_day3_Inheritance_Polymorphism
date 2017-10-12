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
            //vehicle baseVehicle = new vehicle(4, 2000, "Black", 55d);//creating the object in Program
            //baseVehicle.Move();//calling a method on the object
            //baseVehicle.Move();
            //Console.WriteLine(baseVehicle.DistanceTraveled);//calling a property



            Console.WriteLine();

            //defining the automobile object
            Automobile auto1 = new Automobile(4, 13, 2, 4, 1500, "Burnt Orange", 89d);
            auto1.Move();
            auto1.Move();
            Console.WriteLine("Auto1 distance traveled: " + auto1.DistanceTraveled);
            //the .distancedTraveled is a property and has to be called


            Console.WriteLine();
            Boat boat1 = new Boat(2, 500, "silver and black", 88d, .9d);
            boat1.Move();
            boat1.Move();
            Console.WriteLine("Boat Distance Traveled: " + boat1.DistanceTraveled);

            Aircraft plane1 = new Aircraft(70, 100000, "Chrome", 600);
            plane1.Move();
            plane1.Move();
            Console.WriteLine("The plane " + plane1.DistanceTraveled);//calling the calculation that accompanies the method
        }
    }
}
