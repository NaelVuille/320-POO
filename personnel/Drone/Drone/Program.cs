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
            int nb_drone = 25;
            int[] posx = new int[nb_drone];//position x du drone
            int[] bat = new int[nb_drone];//pourcentage de la battrie
            Random random = new Random();

            var Drone = new Drone();

            for(int i = 0;i < nb_drone; i++)
            {
                bat[i] = random.Next(2, 100);
            }
            

            //boucle du drone qui avance
            do
            {
                Console.Clear();
                Etat(ref posx, ref bat, nb_drone);
                DrawDrone(ref posx, ref bat, posy,nb_drone);
                Thread.Sleep(150);
            } while (1 > 0);

        }
        //Etat du drone
        static void Etat (ref int[] posx, ref int[] bat,int nb_drone)
        {
            for (int i = 0;i < nb_drone ; i++) { 
                if (bat[i] > 0) {
                    posx[i] += 1;
                    bat[i] -= 2;
                }
            }
        }
        //dessin du drone
        static void DrawDrone(ref int[] posx,ref int[] bat,int posy,int nb_drone)
        {
            for (int i = 0; i < nb_drone; i++)
            {
                Console.SetCursorPosition(posx[i], posy+i);
                if (bat[i] > 0)
                {
                    Console.Write("x-");
                    Console.Write(bat[i] + "%");
                    Console.Write("-x");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("_____");
                    Console.ForegroundColor= ConsoleColor.White;
                }
                
                
            }
        }
    }
}
