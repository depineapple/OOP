using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Vehicle: SpeedChecker,IMovable
    {
        public string VehicleName { get; set; }
        public int PeopleCapacity { get; set; }
        public abstract int MaxSpeed { get; set; }
        public abstract int MinSpeed { get; set; }
        private int currentSpeed;
        public int CurrentSpeed
        {
            get => currentSpeed;
            set
            {
                if (value < MinSpeed) currentSpeed = 0;
                else if (value > MaxSpeed) currentSpeed = MaxSpeed;
                else currentSpeed = value;
            }
        }

        public Vehicle(string vehicleName, int peopleCapacity)
        {
            VehicleName = vehicleName;
            PeopleCapacity = peopleCapacity;
        }

        public abstract void MoveForward();
        public abstract void MoveBackward();
        public abstract void MoveRight();
        public abstract void MoveLeft();
        public abstract void MoveStart();
        public abstract void MoveStop();

    }
}
