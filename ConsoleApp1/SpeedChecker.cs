using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class SpeedChecker
    {

        public int setCurrentSpeed(int currentSpeed, int minSpeed, int maxSpeed)
        {
            if (!checkSpeedMaxLimit(currentSpeed, maxSpeed))
                return maxSpeed;
            else if (!checkSpeedMinLimit(currentSpeed, minSpeed))
                return minSpeed;
            else return currentSpeed;
        }
        bool checkSpeedMaxLimit(int currentSpeed, int maxSpeed)
        {
            if (currentSpeed <= maxSpeed)
                return true;
            return false;
        }

        bool checkSpeedMinLimit(int currentSpeed, int minSpeed)
        {
            if (currentSpeed >= minSpeed)
                return true;
            return false;
        }
    }
}
