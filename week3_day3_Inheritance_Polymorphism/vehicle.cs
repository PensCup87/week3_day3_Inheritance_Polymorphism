using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3_day3_Inheritance_Polymorphism
{
    class vehicle
    {
        //fields
        private int seats;
        private int carryingCapacity;
        private string color;
        private double movementSpeed;
        private float gearRatio;
        private float engineSize;
        private double distanceTraveled;


        //Properties - made public so the Program.cs can access
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
        public void Move()
        {
            //distanceTraveled = distanceTraveled + movementSpeed;
            distanceTraveled += movementSpeed;
        }
        
    }
}
