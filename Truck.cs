using System;
using System.Collections.Generic;
using System.Text;

namespace AutoTruck
{
    public static class Trucks
    {
        public static List<Truck> AllTrucks { get; set; } = new List<Truck>();
    }


    public class Truck
    {
        public string RegistrationNumber { get; }
        public string Brand { get; }
        public string Model { get; }
        public int HoldCapacity { get; }

        public Truck(string registrationNumber,string brand, string model, int holdCapacity)
        {
            HoldCapacity = holdCapacity;
            Model = model;
            Brand = brand;
            RegistrationNumber = registrationNumber;
        }

    }
}
