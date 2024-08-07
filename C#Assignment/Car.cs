using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Assignment
{
    internal class Car : IVehicle, IDrivable
    {
        private int gasolineAmount;

        public Car(int GasolineAmount)
        {
            this.gasolineAmount = GasolineAmount;
        }

        public void Accelerate()
        {
            throw new NotImplementedException();
        }

        public void Drive()
        {
            if (gasolineAmount > 0)
                Console.WriteLine("the car is Driving");
        }

        public void Move()
        {
            throw new NotImplementedException();
        }

        public bool Refuel(int AmountOfGasoline)
        {
            gasolineAmount += AmountOfGasoline;
            return true;
        }
    }
}
