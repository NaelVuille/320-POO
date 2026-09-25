using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones.Model
{
    public class Charger
    {
        private int _x;
        private int _y;

        private int _size = 20;

        public int X
        {
            get
            {
                return X;
            }
        }

        public int Y
        {
            get
            {
                return _y;
            }
        }

        public Charger(int x, int y)
        {
            _x = x;
            _y = y;
        }
        public void Render(BufferedGraphics drawingSpace)
        {
            Pen pen = new Pen(Color.Black, 3);
            drawingSpace.Graphics.DrawEllipse(pen, _x - _size / 2, _y - _size / 2, _size, _size);
        }


    }
}
