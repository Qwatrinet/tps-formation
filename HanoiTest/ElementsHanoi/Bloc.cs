namespace ElementsHanoi
{
    /// <summary>
    /// Une pièce amovible d'une tour du jeu des tours de Hanoï.
    /// </summary>
    public class Bloc
    {
        /// <summary>
        /// La largeur du bloc.
        /// </summary>
        private int largeur;

        /// <summary>
        /// Crée un bloc.
        /// </summary>
        /// <param name="largeur">Largeur du bloc.</param>
        /// <exception cref="ArgumentException">Une taille négative a été envoyée.</exception>
        public Bloc(int largeur)
        {
            if (largeur <= 0)
            {
                throw new ArgumentException("La largeur d'un bloc doit être positive.", nameof(largeur));
            }
            this.largeur = largeur;
        }
        /// <summary>
        /// Largeur du bloc.
        /// </summary>
        public int Largeur { get => largeur; set => largeur = value; }

        public override string ToString()
        {
            return (largeur + " ");
        }

    }
}
