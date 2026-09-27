using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones.Model
{
    public class Client
    {
        private int _x;
        private int _y;
        private string _nom;
        private const int _SIZE = Helpers.ConfigHelpers.CLIENTS_SIZE;
        public Client(int x, int y, string nom)
        {
            this._x = x;
            this._y = y;
            this._nom = nom;
        }
        public void Render(BufferedGraphics drawingSpace)
        {
            drawingSpace.Graphics.FillRectangle(Brushes.Green, _x - _SIZE / 2, _y - _SIZE / 2, _SIZE, _SIZE);
        }
    }
}
