using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class AirVehicle : Vehicle, IFlyable
    {
        private int minSpeed = 0;
        private int maxSpeed = 11850;
        public override int MinSpeed
        {
            get => minSpeed;
            set
            {
                if (value < minSpeed) minSpeed = 0;
            }
        }
        public override int MaxSpeed
        {
            get => maxSpeed;
            set
            {
                if (value > maxSpeed) maxSpeed = 11850;
            }
        }

        public AirVehicle(string vehicleType, int peopleCapacity, int minSpeed, int maxSpeed) : base(vehicleType, peopleCapacity) 
        {
            this.minSpeed = minSpeed;
            this.maxSpeed = maxSpeed;
        }
        public override void MoveStart()
        {
            Console.WriteLine(VehicleName + " начал движение");
        }
        public override void MoveStop()
        {
            Console.WriteLine(VehicleName + " закончил движение");
        }
        public override void MoveForward()
        {
            setCurrentSpeed(CurrentSpeed, minSpeed, maxSpeed);
            CurrentSpeed += 300;
            Console.WriteLine(VehicleName + " двигается вперёд со скоростью " + CurrentSpeed + " км/ч");
        }

        public override void MoveBackward()
        {
            setCurrentSpeed(CurrentSpeed, minSpeed, maxSpeed);
            CurrentSpeed -= 300;
            Console.WriteLine(VehicleName + " двигается назад со скоростью " + CurrentSpeed + " км/ч");
        }

        public override void MoveRight()
        {
            Console.WriteLine(VehicleName + " двигается вправо");
        }

        public override void MoveLeft()
        {
            Console.WriteLine(VehicleName + " двигается влево");
        }

        public void TakeOff()
        {
            Console.WriteLine(VehicleName + " взлетает");
        }

        public void Land()
        {
            Console.WriteLine(VehicleName + " заходит на посадку");
        }
    }
}
