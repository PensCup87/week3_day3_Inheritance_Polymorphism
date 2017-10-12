using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3_day3_Inheritance_Polymorphism
{
    class Automobile : vehicle
    {
        //want this class to inherit from BaseVehicle with : vehicle
        //has all fields of vehicle and automobile
        private int numberOfWheels;
        private float wheelSize;
        private int numberOfDoors;
        //cant access fields (PRIVATE ACCESS), but can ACCESS THEM THROUGH Properties


        public int NumberOfWheels
        {
            get { return this.numberOfWheels; }
        }


        //constructor
        public Automobile(int numberOfWheels, float wheelSize, int numberOfDoors, int seats, int carryingCapacity, string color, double movementSpeed)
        {
            //these fields are in the Automobile Class
            this.numberOfWheels = numberOfWheels;
            this.wheelSize = wheelSize;
            this.numberOfDoors = numberOfDoors;

            //the below fields are borrowed from the Vehicle Class - Called from Parent Class
            this.seats = seats;
            this.carryingCapacity = carryingCapacity;
            this.color = color;
            this.movementSpeed = movementSpeed;

        }

    }
}
