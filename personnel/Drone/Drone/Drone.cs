using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Drone
{
    public class Drone
    {
        //Properties
        private int _posx;
        private int _posy;
        private int _batterie;

        public int Batterie { get => _batterie; }

        public Drone(int posx, int posy, int batterie)
        {
            this._posx = posx;
            this._posy = posy;
            this._batterie = batterie;
        }

        public Drone()
        {
            this._posx = 0;
            this._posy = 0;
            this._batterie = 50;
        }

        public void change()
        {
            if (Batterie <= 0) return;

            _posx++;
            _batterie -= 2;

        }
        public void Draw()
        {
            Console.SetCursorPosition(_posx, _posy);
            if (Batterie > 0)
            {
                Console.Write("x-");
                Console.Write(Batterie + "%");
                Console.Write("-x");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("_____");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}
