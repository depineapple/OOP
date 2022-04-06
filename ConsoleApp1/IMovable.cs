using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal interface IMovable
    {
        public int MaxSpeed { get; set; }
        public int MinSpeed { get; set; }
        public int CurrentSpeed { get; set; }
        void MoveForward();
        void MoveBackward();
        void MoveRight();
        void MoveLeft();
    }
}
