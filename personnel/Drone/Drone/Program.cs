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
            const int posy = 0;//position y du drone

            //déclaration variable
            int posx = 0;//position x du drone
            int bat = 50;//pourcentage de la battrie

            //boucle du drone qui avance
            do
            {
                Console.Clear();
                Etat(ref posx, ref bat);
                Drone(ref posx, ref bat, posy);
                Thread.Sleep(150);
            } while (bat > 0);

            //affiche le drone mort
            Console.Clear();
            Drone(ref posx, ref bat, posy);
            Console.ReadLine();

        }
        //Etat du drone
        static void Etat (ref int posx, ref int bat)
        {
            if (bat > 0) { 
                posx += 1;
                bat -= 2;
            }
        }
        //dessin du drone
        static void Drone(ref int posx,ref int bat,int posy)
        {
            
            Console.SetCursorPosition(posx, posy);
            if (bat > 0)
            {
                Console.WriteLine("x-O-x");
        
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("_____");
            }
            Console.SetCursorPosition(posx+1, posy+1);
            Console.WriteLine(bat + "%");
        }
    }
}
