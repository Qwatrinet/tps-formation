using StagiaireLib;
using System.Windows.Forms;

namespace TrouveEmploiEvaluation
{
    public partial class ConfirmationInscription : Form
    {
        public ConfirmationInscription(Stagiaire stagiaire)
        {
            InitializeComponent();
            labelBienvenue.Text = "Bienvenue " + stagiaire.Prenom + " " + stagiaire.Nom + "\n" + "La section " + stagiaire.GenNomSection() + " vous attend!";
            if (stagiaire.Nom != "Truite" && stagiaire.Prenom != "Truite")
            {
                pictureBoxTruite.Image = null;
            }
        }


    }
}
