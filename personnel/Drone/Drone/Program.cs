using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Drone
{
    internal class Program
    {


        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            int Count = 0;

            List<Drone> drones = new List<Drone> { 
                new Drone(1,1,50),
                new Drone(1,5,60)
            };


            while (OneIsAlive (drones))
            {
                Console.Clear();
                foreach (Drone drone in drones)
                {  
                    drone.change();
                    drone.Draw();
                }
                Thread.Sleep(150);

                Count++;
                if (Count == 10) 
                { 
                    drones.Add(new Drone(1, 20, 100));
                    Count = 0;
                }
            }
        Console.ReadKey();
        }
        
        static bool OneIsAlive(List<Drone> drones)
        {
            foreach (Drone drone in drones)
            {
                if(drone.Batterie > 1)
                return true;
            }
            return false;
        }

    }
}
