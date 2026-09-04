using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Drone
{
    internal class Program
    {


        static void Main(string[] args)
        {
            int nb_drone = 20;
            Drone drone = new Drone();

            drone.move();
            
            Console.ReadKey();
        }
        

    }
}
