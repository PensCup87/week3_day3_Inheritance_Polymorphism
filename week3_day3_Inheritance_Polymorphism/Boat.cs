using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3_day3_Inheritance_Polymorphism
{
    class Boat : vehicle
    {
        //   : vehicle inherits the properties of "Vehicle"
        private double waterDrag;


        //COnstructor
        public Boat(int seats, int carryingCapacity, string color, double movementSpeed, double waterDrag)
        {
            this.seats = seats;
            this.carryingCapacity = carryingCapacity;
            this.color = color;
            this.movementSpeed = movementSpeed;
            this.waterDrag = waterDrag;
        }
            //Calculate WatherDrag -> Over riding A Method with 
            //"virtual" keyword - gives a child class permission to make an exception/own version
            //child class can write its own version of a Method
            //VIRTUAL IS ADDED TO THE METHOD IN PARENT CLASS

            //OVERRIDE - child class makes its own, specialized version of an establised METHOD
            //override lists new steps for the updated method
            //BASE is a keyword to call a method from a parent class -> base.MethodName()
            //base allows you to use parts of the parent method as needed in the updated method

            public override void Move()
        {

            //base.Move(); - not able to use everything in MOVE YEt
            distanceTraveled += movementSpeed * waterDrag;
        }








    }
    }

