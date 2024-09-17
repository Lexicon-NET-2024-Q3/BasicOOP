using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOOP2024Q3
{
    internal interface IDrivable
    {
        string Drive(int distance); 
    }
    internal interface IStopable
    {
        void Stop(); 
    }
    internal class Vehicle : IDrivable
    {
        public string Brand { get; set; }

        public Vehicle(string brand)
        {
            Brand = brand; 
        }

        public string Drive(int distance)
        {
            return $"{GetType().Name} drove for {distance}"; 
        }
    }

    internal class Car : Vehicle, IStopable
    {
        public string Model { get; set; }
        public Car(string brand, string model) : base(brand)
        {
            Model = model; 
        }

        public void Stop()
        {
            //Do something
        }
    }
}
