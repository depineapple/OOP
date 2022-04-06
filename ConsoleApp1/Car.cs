using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Car : GroundVehicle
    {
        public int WheelsCount { get; }
        public Car(string vehicleType, int peopleCapacity, int minSpeed, int maxSpeed, int wheelsCount) : 
            base(vehicleType, peopleCapacity, minSpeed, maxSpeed)
        {
            WheelsCount = wheelsCount;
        }
    }
}
