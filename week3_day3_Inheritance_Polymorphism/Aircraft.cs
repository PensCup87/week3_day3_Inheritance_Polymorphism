using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3_day3_Inheritance_Polymorphism
{
    class Aircraft : vehicle
    {
        private double altitude;//field
        public Aircraft(int seats, int carryingCapacity, string color, double movementSpeed)//consreuctor
        {
            this.seats = seats;
            this.carryingCapacity = carryingCapacity;
            this.color = color;
            this.movementSpeed = movementSpeed;

            this.altitude = 0.0d;//starts on the ground - move method moves it forward/in the air

        }

            public override void Move()
        {
            altitude = altitude + 10000d;
            base.Move();//keeping this becuse the aircraft moves forward
        }
        //override - to make a used method specific to this class - to INCLUDE THE ALTITUDE
        public override string GetDistanceTraveled()
        {
            return "Altitude: " + altitude + " - " +base.GetDistanceTraveled();
        }


    }
    }

