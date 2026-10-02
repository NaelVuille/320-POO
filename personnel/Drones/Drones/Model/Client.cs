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
        private const int _HALFSIZE = _SIZE / 2;
        public Client(int x, int y, string nom)
        {
            this._x = x;
            this._y = y;
            this._nom = nom;
        }
        public void Render(BufferedGraphics drawingSpace)
        {
            drawingSpace.Graphics.FillRectangle(Brushes.Green, _x - _HALFSIZE, _y - _HALFSIZE, _SIZE, _SIZE);
        }
        public static void RegisterClient(List<Client> clients, int i, List<Pizzeria> pizzerias, List<Charger> bornes)
        {
            int securityDistance = _HALFSIZE;
            int x = Helpers.RandomHelpers.Next(_HALFSIZE, Config.AIRSPACE_WIDTH - _HALFSIZE);
            int y = Helpers.RandomHelpers.Next(_HALFSIZE, Config.AIRSPACE_HEIGHT - _HALFSIZE);

            foreach (Pizzeria pizzeria in pizzerias)
            {
                securityDistance = Helpers.ConfigHelpers.PIZZARIAS_SIZE / 2;
                if ((x + securityDistance >= pizzeria.x - securityDistance && x - securityDistance <= pizzeria.x + securityDistance) && (y + securityDistance >= pizzeria.y - securityDistance && y - securityDistance <= pizzeria.y + securityDistance))
                {
                    throw new Exception("Chevauchement d'un client sur une pizzeria");
                }

            }

            foreach (Client client in clients)
            {
                securityDistance = (_HALFSIZE) * 5;
                if ((x + securityDistance >= client._x - securityDistance && x - securityDistance <= client._x + securityDistance) && (y + securityDistance >= client._y - securityDistance && y - securityDistance <= client._y + securityDistance))
                {
                    throw new Exception("Distance clients");
                }
            }

            foreach (Charger borne in bornes)
            {
                if ((x + securityDistance >= borne.X - securityDistance && x - securityDistance <= borne.X + securityDistance) && (y + securityDistance >= borne.Y - securityDistance && y - securityDistance <= borne.Y + securityDistance))
                {
                    throw new Exception("Chevauchement d'un client sur une borne de charge");
                }
            }


            clients.Add(new Client(x, y, "Client numéro " + i));
            return;
        }
    }
}
