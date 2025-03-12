using System.Diagnostics;

namespace ElementsHanoi
{
    /// <summary>
    /// Cette classe représente le support du jeu des tours de Hanoï, composée de 3 tours.
    /// </summary>
    public class Jeu
    {
        /// <summary>
        /// Liste des tours qui composent le jeu.
        /// </summary>
        private List<Tour> tours;

        /// <summary>
        /// Initialise un jeu de trois tours. La première contient un empilement de blocs de taille size.
        /// </summary>
        /// <param name="NombreDeBlocsInitial">taille de la tour de depart</param>
        /// /// <exception cref="ArgumentException">On a entré un paramètre taille négatif ou 0.</exception>
        public Jeu(int NombreDeBlocsInitial)
        {
            if (NombreDeBlocsInitial <= 0)
            {
                throw new ArgumentException("La taille de la tour de départ doit être positive.");
            }
            tours = new List<Tour>();
            List<Bloc> blocs = new List<Bloc>();
            for (int i = NombreDeBlocsInitial; i > 0; i--)
            {
                blocs.Add(new Bloc(i));
            }
            Tour tour1 = new Tour(blocs);
            Tour tour2 = new Tour(new List<Bloc>());
            Tour tour3 = new Tour(new List<Bloc>());
            tours.Add(tour1);
            tours.Add(tour2);
            tours.Add(tour3);
            DeplacerTour(tours[0], tours[2], tours[1], NombreDeBlocsInitial);
            Trace.WriteLine(this.ToString());
        }

        /// <summary>
        /// Déplacer la tour de Hanoï bloc par bloc suivant les règles: 
        /// Bloc par bloc et on n'empile jamais de grand bloc sur un plus petit.
        /// </summary>
        /// <param name="depart">Tour de départ</param>
        /// <param name="destination">Tour d'arrivée</param>
        /// <param name="destinationIntermediaire">Tour intermédiaire du jeu</param>
        /// <param name="nombreBlocDeLaTour">Nombre de blocs à déplacer</param>
        /// <exception cref="Exception">On essaie de déplacer une tour sur une autre qui n'existe pas.</exception>
        private void DeplacerTour(Tour depart, Tour destination, Tour destinationIntermediaire, int nombreBlocDeLaTour)
        {
            if (depart == destination || depart == destinationIntermediaire || destination == destinationIntermediaire)
            {
                throw new ArgumentException("il y a 2 paramètres identiques!");
            }
            if (nombreBlocDeLaTour < 1)
            {
                throw new ArgumentException("Il faut déplacer un nombre positif de blocs");
            }
            if (nombreBlocDeLaTour == 1)
            {
                depart.DeplacerBloc(destination);
                return;
            }

            //On déplace la tour sauf la base dans la position intermédiaire
            DeplacerTour(depart, destinationIntermediaire, destination, nombreBlocDeLaTour - 1);

            //On déplace la base
            depart.DeplacerBloc(destination);

            //On déplace la tour intermédiaire sur la destination
            DeplacerTour(destinationIntermediaire, destination, depart, nombreBlocDeLaTour - 1);

        }

        public override string ToString()
        {
            string s = "Etat du jeu: \n";
            foreach (Tour tour in tours)
            {
                s += tour.ToString() + "\n";
            }
            return s;
        }

    }
}
