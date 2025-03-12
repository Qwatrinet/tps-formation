namespace ElementsHanoi
{
    /// <summary>
    /// Une tour du jeu des tours de Hanoï. 
    /// </summary>
    public class Tour
    {
        /// <summary>
        /// La liste des blocs qui composent cette tour.
        /// </summary>
        private List<Bloc> blocs;

        internal List<Bloc> Blocs { get => blocs; set => blocs = value; }

        /// <summary>
        /// Crée une tour déterminée par son numéro d'identification. Elle contient les blocs listés dans blocs.
        /// </summary>
        /// <param name="numero">l'ID de la tour</param>
        /// <param name="blocs">La liste des blocs contenus dans la tour</param>
        public Tour(List<Bloc> blocs)
        {
            foreach (Bloc bloc in blocs)
            {
                foreach (Bloc b in blocs)
                {
                    if (b != bloc && b.Largeur <= bloc.Largeur)
                    {
                        throw new ArgumentException("La tour est invalide!");
                    }
                }
            }
            this.blocs = blocs;
        }

        /// <summary>
        /// Vérifie qu'on peut déplacer le dernier bloc de notre tour au dessus d'un autre bloc.
        /// </summary>
        /// <param name="blocDArriveeATester">Le bloc sur lequel on veut empiler le dernier bloc de notre tour.</param>
        /// <returns></returns>
        public bool LegaliteDeplacement(Bloc blocDArriveeATester)
        {
            if (blocDArriveeATester == null)
            {
                return true;
            }
            return this.blocs.Last().Largeur < blocDArriveeATester.Largeur;
        }
        /// <summary>
        /// Déplace le bloc de la tour actuelle à une tour de destination.
        /// </summary>
        /// <param name="destination">La tour de destination.</param>
        /// <exception cref="Exception">On a tenté un mouvement impossible.</exception>
        public void DeplacerBloc(Tour destination)
        {
            if (this.blocs.Count == 0)
            {
                throw new Exception("pas de bloc à déplacer!");
            }
            Bloc blocADeplacer = this.blocs.Last();

            if (destination.blocs.Count > 0)
            {
                if (!LegaliteDeplacement(destination.blocs.Last()))
                {
                    throw new Exception("mouvement illégal");
                }
            }

            this.blocs.Remove(blocADeplacer);
            destination.blocs.Add(blocADeplacer);
        }

        public override string ToString()
        {
            string s = "Tour ";

            foreach (Bloc bloc in blocs)
            {
                s += bloc.ToString();
            }
            return s;
        }
    }
}
