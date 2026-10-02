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
        private const int _HALFSIZE = _SIZE / 2;
        public Pizzeria(int x, int y, string nom) 
        {
            this.x = x;
            this.y = y;
            this._nom = nom;
        }
        public void Render(BufferedGraphics drawingSpace)
        {
            Pen pen = new Pen(Color.Gray, 3);
            drawingSpace.Graphics.DrawRectangle(pen, x - _HALFSIZE, y - _HALFSIZE/ 2, _SIZE, _SIZE);
        }
        public static void RegisterPizzeria(List<Pizzeria> pizzerias, int i,List<Charger> bornes)
        {
            int x = Helpers.RandomHelpers.Next(_HALFSIZE, Config.AIRSPACE_WIDTH - _HALFSIZE);
            int y = Helpers.RandomHelpers.Next(_HALFSIZE, Config.AIRSPACE_HEIGHT - _HALFSIZE);
            

            foreach (Pizzeria pizzeria in pizzerias)
            {
                if ((x + _HALFSIZE >= pizzeria.x - _HALFSIZE && x - _HALFSIZE <= pizzeria.x + _HALFSIZE) && (y + _HALFSIZE >= pizzeria.y - _HALFSIZE && y - _HALFSIZE <= pizzeria.y + _HALFSIZE))
                {
                    throw new Exception("Chevauchement de pizzerias");
                }
            }

            foreach (Charger borne in bornes)
            {
                if ((x + _HALFSIZE >= borne.X - _HALFSIZE && x - _HALFSIZE <= borne.X + _HALFSIZE) && (y + _HALFSIZE >= borne.Y - _HALFSIZE && y - _HALFSIZE <= borne.Y + _HALFSIZE))
                {
                    throw new Exception("Chevauchement d'une pizzeria sur une borne de charge");
                }
            }

            pizzerias.Add(new Pizzeria(x, y, "Pizzeria numéro " + i));
            return;
        }
    }
    
}
