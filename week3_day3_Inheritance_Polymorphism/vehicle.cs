using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3_day3_Inheritance_Polymorphism
{
   abstract class vehicle
    {
        //not supposed to create an INSTANCE OF AN ABSTRACT CLASS
        //forces others to inherit the fields, properties, and methods
        //fields
        protected int seats;
        protected int carryingCapacity;
        protected string color;
        protected double movementSpeed;
        //private float gearRatio;
        //private float engineSize;
        protected double distanceTraveled;


        //Properties - made public so the Program.cs can access
        //allow interaction without having to use a Method
        public int Seats
        {
            get { return this.seats; }
        }
        public int CarryingCapacity
        {
            get { return this.carryingCapacity; }
        }
        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }
        public double DistanceTraveled
        {
            get { return this.distanceTraveled; }
        }

        //Constructors
        public vehicle()//Constructor Has to Match Class Name - Case Sensitive
            {
            //default constructor
            }

        public vehicle(int seats, int carryingCapacity, string color, double movementSpeed)//variables here can be changed
        {
            this.seats = seats;
            this.carryingCapacity = carryingCapacity;
            this.color = color;
            this.movementSpeed = movementSpeed;//no property because dont want to be able to alter after creating the object
            this.distanceTraveled = 0.0d; //setting odometer to Zero; Does not Have to BE A Parameter because We are Setting Value
            //dTraveled will be tracked, but the enduser can not adjust its value {HAS A GET PROPERTY}
        }

        //Added a Method
        //THen CHNAGED TO VIRTUAL
        public virtual void Move()
        {
            //distanceTraveled = distanceTraveled + movementSpeed;
            distanceTraveled += movementSpeed;
        }

        //REFACTORING
        
    }
}
