using Drones.Model;

namespace Drones
{
    // La classe AirSpace repr�sente le territoire au dessus duquel les drones peuvent voler
    // Il s'agit d'un formulaire (une fen�tre) qui montre une vue 2D depuis en dessus
    // Il n'y a donc pas de notion d'altitude qui intervient

    public partial class AirSpace : Form
    {
        // La flotte est l'ensemble des drones qui �voluent dans notre espace a�rien
        private List<Drone> _fleet;
        private List<Charger> _bornes;
        private List<Pizzeria> _pizzerias;
        private List<Client> _clients;

        private BufferedGraphicsContext _currentContext;
        private BufferedGraphics _airspace;

        // Initialisation de l'espace a�rien avec un certain nombre de drones
        public AirSpace(List<Drone> fleet, List<Charger> bornes, List<Pizzeria> pizzerias, List<Client>clients)
        {
            InitializeComponent();
            this.ClientSize = new Size(Config.AIRSPACE_WIDTH, Config.AIRSPACE_HEIGHT);
            // Gets a reference to the current BufferedGraphicsContext
            _currentContext = BufferedGraphicsManager.Current;
            // Creates a BufferedGraphics instance associated with this form, and with
            // dimensions the same size as the drawing surface of the form.
            _airspace = _currentContext.Allocate(this.CreateGraphics(), this.DisplayRectangle);
            _fleet = fleet;
            _bornes = bornes;
            _pizzerias = pizzerias;
            _clients = clients;
        }

        // Affichage de la situation actuelle
        private void Render()
        {
            _airspace.Graphics.Clear(Color.AliceBlue);

            // draw drones
            foreach (Drone drone in _fleet)
            {
                drone.Render(_airspace);
            }
            foreach (Charger charger in _bornes) 
            { 
                charger.Render(_airspace);
            }
            foreach (Pizzeria pizzeria in _pizzerias)
            {
                pizzeria.Render(_airspace);
            }
            foreach (Client client in _clients)
            {
                client.Render(_airspace);
            }

            _airspace.Render();
        }

        // Calcul du nouvel �tat apr�s que 'interval' millisecondes se sont �coul�es
        private void Update(int interval)
        {
            foreach (Drone drone in _fleet)
            {
                drone.Update(interval,_bornes);
            }
        }

        // M�thode appel�e � chaque frame
        private void NewFrame(object sender, EventArgs e)
        {
            this.Update(ticker.Interval);
            this.Render();
        }
    }
}