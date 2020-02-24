using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    internal class Car
    {
        //details on the operation of a car
        //abstract / hide away these details from other classes
        #region Private Methods

        private void InjectFuel()
        {

        }

        private void Ignition()
        {

        }

        private void IncreaseAirIntake()
        {

        }

        private void DecreaseAirIntake()
        {

        }

        private void IncreaseFuelIntake()
        {

        }

        private void DecreaseFuelIntake()
        {

        }

        private void IncreaseBreaklinePressure()
        {

        }

        private void DecreaseBreaklinePressure()
        {

        }

        #endregion

        #region Public Methods

        public void StartEngine()
        {
            this.InjectFuel();
            this.IncreaseAirIntake();
            this.Ignition();
        }

        public void SpeedUp()
        {
            this.IncreaseAirIntake();
            this.IncreaseFuelIntake();
        }

        public void SlowDown()
        {
            this.DecreaseAirIntake();
            this.DecreaseFuelIntake();
        }

        public void ApplyBreak()
        {
            SlowDown();
            this.IncreaseBreaklinePressure();
        }

        public void Stop()
        {
            ApplyBreak();
            HoldBreak();
        }

        public void HoldBreak() { }

        #endregion
    }
}
