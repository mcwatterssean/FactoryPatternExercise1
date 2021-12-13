using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattenExercise1
{
    public class Motorcycle : IVehicle
    {
        public Motorcycle()
            {

            }

        public void Drive()
        {
            Console.WriteLine("The Motorcycle is revving up");
        }




    }

}
