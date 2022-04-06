using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Helicopter: AirVehicle
    {
        public int BladesCount { get; }
        private int maxSpeed = 415;
        public override int MaxSpeed
        {
            get => maxSpeed;
            set
            {
                if (value > maxSpeed) maxSpeed = 415;
            }
        }

        public Helicopter(string vehicleType, int peopleCapacity, int minSpeed, int maxSpeed, int bladesCount) : 
            base(vehicleType, peopleCapacity, minSpeed, maxSpeed)
        {
            BladesCount = bladesCount;
        }
    }
}
