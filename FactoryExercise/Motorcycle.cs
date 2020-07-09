using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryExercise
{
    public class Motorcycle : IVehicle
    {
        public Motorcycle()
        {
           
        }

        public void Drive()
        {
            Console.WriteLine("The MotorCycle is loud!");
            Console.WriteLine("Vroooommmm!!!");
        }
    }
}
