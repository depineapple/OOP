using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class WaterVehicle : Vehicle
    {
        private int minSpeed = 0;
        private int maxSpeed = 511;
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
                if (value > maxSpeed) maxSpeed = 511;
            }
        }

        public WaterVehicle(string vehicleType, int peopleCapacity, int minSpeed, int maxSpeed) : base(vehicleType, peopleCapacity)
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
            CurrentSpeed += 120;
            Console.WriteLine(VehicleName + " двигается вперёд со скоростью " + CurrentSpeed + " км/ч");
        }

        public override void MoveBackward()
        {
            setCurrentSpeed(CurrentSpeed, minSpeed, maxSpeed);
            CurrentSpeed -= 120;
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
    }
}
