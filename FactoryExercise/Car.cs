using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryExercise
{
    public class Car : IVehicle
    {
        public Car()
        {

        }

        public void Drive()
        {
            Console.WriteLine("The Car is driving! Wooo!");
        }
    }
}
