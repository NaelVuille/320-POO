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
            int nb_drone = 20;
            int[] bat = new int[nb_drone];//pourcentage de la battrie
            Random random = new Random();

            for(int i = 0;i < nb_drone-1; i++)
            {
                bat[i] = random.Next(2, 100);
            }
            



            //boucle du drone qui avance
            do
            {
                Console.Clear();
                Etat(ref posx, ref bat);
                Drone(ref posx, ref bat, posy,nb_drone);
                Thread.Sleep(150);
            } while (1 > 0);

            //affiche le drone mort
            Console.Clear();
            Drone(ref posx, ref bat, posy,nb_drone);
            Console.ReadLine();

        }
        //Etat du drone
        static void Etat (ref int posx, ref int[] bat)
        {
            for (int i = 0; ; i++) { 
                if (bat[i] > 0) { 
                    posx += 1;
                    bat[i] -= 2;
                }
            }
        }
        //dessin du drone
        static void Drone(ref int posx,ref int[] bat,int posy,int nb_drone)
        {
            for (int i = 0; i < nb_drone; i++)
            {
                Console.SetCursorPosition(posx, posy+i);
                if (bat[i] > 0)
                {
                    Console.WriteLine("x-O-x");

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("_____");
                }
                Console.SetCursorPosition(posx + 1, posy + i);
                Console.WriteLine(bat[i] + "%");
            }
        }
    }
}
