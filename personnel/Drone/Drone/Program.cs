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
            Console.CursorVisible = false;

            Drone[] drones = new Drone[2];

            for (int i = 0; i < drones.Length-1; i++)
            {
                while (drones[i].Batterie > 1)
                {
                    Console.Clear();
                    drones[i].change();
                    drones[i].Draw();
                    Thread.Sleep(150);

                }
            }
            
            Console.ReadKey();
        }
        

    }
}
