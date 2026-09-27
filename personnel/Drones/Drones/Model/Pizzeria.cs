using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones.Model
{
    public class Pizzeria
    {
        public int x;
        public int y;
        private string _nom;
        private const int _SIZE = Helpers.ConfigHelpers.PIZZARIAS_SIZE;
        public Pizzeria(int x, int y, string nom) 
        {
            this.x = x;
            this.y = y;
            this._nom = nom;
        }
        public void Render(BufferedGraphics drawingSpace)
        {
            Pen pen = new Pen(Color.Gray, 3);
            drawingSpace.Graphics.DrawRectangle(pen, x - _SIZE / 2, y - _SIZE / 2, _SIZE, _SIZE);
        }
        public static void RegisterPizzeria(List<Pizzeria> pizzerias, int i,List<Charger> bornes)
        {
            int Size = Helpers.ConfigHelpers.PIZZARIAS_SIZE / 2;
            int x = Helpers.RandomHelpers.Next(Size, Config.AIRSPACE_WIDTH - Size);
            int y = Helpers.RandomHelpers.Next(Size, Config.AIRSPACE_HEIGHT - Size);
            

            foreach (Pizzeria pizzeria in pizzerias)
            {
                if ((x + Size >= pizzeria.x - Size && x - Size <= pizzeria.x + Size) && (y + Size >= pizzeria.y - Size && y - Size <= pizzeria.y + Size))
                {
                    throw new Exception("Chevauchement de pizzerias");
                }
            }

            foreach (Charger borne in bornes)
            {
                if ((x + Size >= borne.X - Size && x - Size <= borne.X + Size) && (y + Size >= borne.Y - Size && y - Size <= borne.Y + Size))
                {
                    throw new Exception("Chevauchement d'une pizzeria sur une borne de charge");
                }
            }

            pizzerias.Add(new Pizzeria(x, y, "Pizzeria numéro " + i));
            return;
        }
    }
    
}
