using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace CheckboxRadios
{
    public class Parametres
    {
        private bool estActif;

        public CouleurFond couleurFond;

        public CouleurCaractères couleurCaractères;

        public Casse casse;


        public Parametres()
        {
            this.estActif = false;
            this.couleurFond = CouleurFond.Aucune;
            this.couleurCaractères=CouleurCaractères.Noir;
            this.casse=Casse.Aucune;
        }

        public CouleurFond CouleurFond
        {
            get => default;
            set
            {
            }
        }

        public CouleurCaractères CouleurCaractères
        {
            get => default;
            set
            {
            }
        }

        public Casse Casse
        {
            get => default;
            set
            {
            }
        }

        public void ActiverParametres()
        {
            this.estActif=true;
        }

        public Color ChangerCouleurFond(CouleurFond couleurFond)
        {
            this.couleurFond=couleurFond;
            switch (couleurFond){
                case CouleurFond.Aucune:
                    return Color.Transparent;
                case CouleurFond.Rouge:
                    return Color.Red;
                case CouleurFond.Bleu:
                    return Color.Blue;
                case CouleurFond.Vert:
                    return Color.Green;
                default:
                    return Color.Transparent;
            }
        }

        public Color changerCouleurCaracteres(CouleurCaractères couleurCaracteres)
        {
            this.couleurCaractères = couleurCaracteres;
            switch (couleurCaracteres) { 
                case CouleurCaractères.Noir:
                    return Color.Black;
                case CouleurCaractères.Rouge:
                    return Color.Red;
                case CouleurCaractères.Blanc:
                    return Color.White;
                default:
                    return Color.Black;
            }
        }

        public void changerCasse(Casse casse)
        {
            this.casse = casse;
        }
    }
}