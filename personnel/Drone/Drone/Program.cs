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
            //déclaration constante
            const int posy = 10;//position y du drone

            //déclaration variable
            int posx = 0;//position x du drone
            int bat = 50;//pourcentage de la battrie

            //boucle de l'action
            do
            {
                Console.Clear();
                Console.SetCursorPosition(posx, posy);
                Console.WriteLine("x-O-x");
                posx += 1;
                bat -= 2;

                Thread.Sleep(150);
            } while (bat > 0);

            Console.Clear();
            Console.SetCursorPosition(posx, posy);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("_____");
            Console.ReadLine();

        }
    }
}
