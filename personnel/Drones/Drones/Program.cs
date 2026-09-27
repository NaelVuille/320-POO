using Drones.Model;
using System.Security.Policy;

namespace Drones
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Cr�ation de la flotte de drones
            List<Drone> fleet= new List<Drone>();
            List<Charger> bornes = new List<Charger>();
            List<Pizzeria> pizzerias = new List<Pizzeria>();
            List<Client> clients = new List<Client>();
            
            for(int i=0; i < 1;i++)
                fleet.Add(new Drone(Config.AIRSPACE_WIDTH / 2, Config.AIRSPACE_HEIGHT / 2, "l'étiquette de l'étiqutteuse"));
            
            bornes.Add(new Charger(Config.AIRSPACE_WIDTH / 2, Config.AIRSPACE_HEIGHT / 2));

            for (int i = 0; i < 5; i++)
                pizzerias.Add(new Pizzeria(Helpers.RandomHelpers.Next(Helpers.ConfigHelpers.PIZZARIAS_SIZE/2,Config.AIRSPACE_WIDTH), Helpers.RandomHelpers.Next(Helpers.ConfigHelpers.PIZZARIAS_SIZE / 2, Config.AIRSPACE_HEIGHT), "Pizzeria numéro " + i));

            for (int i = 0; i < 20; i++)
            {
                clients.Add(new Client(Helpers.RandomHelpers.Next(Helpers.ConfigHelpers.CLIENTS_SIZE / 2, Config.AIRSPACE_WIDTH), Helpers.RandomHelpers.Next(Helpers.ConfigHelpers.CLIENTS_SIZE / 2, Config.AIRSPACE_HEIGHT), "clients numéro " + i));
            }

            // D�marrage
            Application.Run(new AirSpace(fleet,bornes,pizzerias,clients));
        }
    }
}