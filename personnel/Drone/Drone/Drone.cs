using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drone
{
    public class Drone
    {
        //Properties
        private int _posx;
        private int _posy;
        private int _batterie;

        public Drone(int posx, int posy, int batterie)
        {
            _posx = posx;
            _posy = posy;
            _batterie = batterie;
        }

        public Drone()
        {
            _posx = 0;
            _posy = 0;
            _batterie = 50;
        }
    }
}
