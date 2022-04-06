using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Plane : AirVehicle
    {
        public int TurbinesCount { get; }
        private int maxSpeed = 11230;
        public override int MaxSpeed
        {
            get => maxSpeed;
            set
            {
                if (value > maxSpeed) maxSpeed = 11230;
            }
        }
        public Plane(string vehicleType, int peopleCapacity, int minSpeed, int maxSpeed, int turbinesCount) : 
            base(vehicleType, peopleCapacity, minSpeed, maxSpeed)
        {
            TurbinesCount = turbinesCount;
        }
    }
}
