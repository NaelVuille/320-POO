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
        public static void RegisterClient(List<Client> clients, int i, List<Pizzeria> pizzerias, List<Charger> bornes)
        {
            int Size = Helpers.ConfigHelpers.CLIENTS_SIZE / 2;
            int x = Helpers.RandomHelpers.Next(Size, Config.AIRSPACE_WIDTH - Size);
            int y = Helpers.RandomHelpers.Next(Size, Config.AIRSPACE_HEIGHT - Size);

            foreach (Pizzeria pizzeria in pizzerias)
            {
                Size = Helpers.ConfigHelpers.PIZZARIAS_SIZE / 2;
                if ((x + Size >= pizzeria.x - Size && x - Size <= pizzeria.x + Size) && (y + Size >= pizzeria.y - Size && y - Size <= pizzeria.y + Size))
                {
                    throw new Exception("Chevauchement d'un client sur une pizzeria");
                }

            }

            foreach (Client client in clients)
            {
                Size = (Helpers.ConfigHelpers.CLIENTS_SIZE / 2) * 5;
                if ((x + Size >= client._x - Size && x - Size <= client._x + Size) && (y + Size >= client._y - Size && y - Size <= client._y + Size))
                {
                    throw new Exception("Distance clients");
                }
            }

            foreach (Charger borne in bornes)
            {
                if ((x + Size >= borne.X - Size && x - Size <= borne.X + Size) && (y + Size >= borne.Y - Size && y - Size <= borne.Y + Size))
                {
                    throw new Exception("Chevauchement d'un client sur une borne de charge");
                }
            }


            clients.Add(new Client(x, y, "Client numéro " + i));
            return;
        }
    }
}
