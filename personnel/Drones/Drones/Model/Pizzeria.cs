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
    }
}
