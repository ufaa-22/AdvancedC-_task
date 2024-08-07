using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedC__task
{
    internal class Car : IVehicle, IDrivable
    {
        private int gasoline;
        public Car(int startingGasoline)
        {
            gasoline = startingGasoline;
        }
        public void Accelerate()
        {
            Console.WriteLine("The car is accelerating.");
        }

        public void Drive()
        {
            if (gasoline > 0)
            {
                Console.WriteLine("The car is driving.");
            }
            else
            {
                Console.WriteLine("No gasoline. Please refuel.");
            }
        }

        public void Move()
        {
            Console.WriteLine("The car is moving.");
        }

        public bool Refuel(int amount)
        {
            gasoline += amount;
            return true;
        }
    }
}
