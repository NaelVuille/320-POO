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
        public int Batterie;

        public Drone(int posx, int posy, int batterie)
        {
            this._posx = posx;
            this._posy = posy;
            this.Batterie = batterie;
        }

        public Drone()
        {
            this._posx = 0;
            this._posy = 0;
            this.Batterie = 50;
        }

        private void change()
        {
            if (Batterie > 0)
            {
                _posx += 1;
                Batterie -= 2;
            }
        }
        private void Draw()
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
        
        public void move()
        {
            while (this.Batterie > 1)
            {
                Console.Clear();
                this.change();
                this.Draw();
                Thread.Sleep(150);

            }
        }
    }
}
