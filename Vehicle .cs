using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceFullTask
{
    internal abstract class Vehicle
    {
        public string Name;
        public string Make;
        public string Model;
        public int Year;

        public abstract void GetInfo();
        public Vehicle(string Name, string Make, string Model, int Year) 
        {
            this.Name = Name;
            this.Make = Make;
            this.Model = Model;
            this.Year = Year;
        }
    }
    internal class Car : Vehicle
    {
        int noOfDoor;
        public Car(string Name, string Make, string Model, int Year, int noOfDoor) : base(Name, Make, Model, Year)
        {
            this.noOfDoor = noOfDoor;
        }
        public override void GetInfo()
        {
            Console.WriteLine("Name: {0}, Make: {1}, Model: {2}, Year: {3}", Name,Make,Model,Year);
        }
    }
    internal class Truck : Vehicle
    {
        public int noOfWheel;
        public Truck(string Name, string Make, string Model, int Year, int noOfWheel) : base(Name, Make, Model, Year)
        {
            this.noOfWheel = noOfWheel;
        }
        public override void GetInfo()
        {
            Console.WriteLine("Name: {0}, Make: {1}, Model: {2}, Year: {3}", Name, Make, Model, Year);
        }
    }
}
