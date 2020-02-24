using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public class Driver
    {
        public void OperateCar()
        {
            Car car = new Car();

            OpenDoor();
            SitDown();
            GetKeysOutOfPocket();

            car.StartEngine();
            car.ApplyBreak();
            car.HoldBreak();
            car.SpeedUp();
        }

        private void OpenDoor() { }
        private void SitDown() { }
        private void GetKeysOutOfPocket() { }
    }
}
