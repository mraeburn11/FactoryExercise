using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryExercise
{
    public class ThreeWheeler : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("This thing is fast!");
        }
    }

    
}
