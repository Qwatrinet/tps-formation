using StagiaireLib;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace TrouveEmploiEvaluation
{
    public partial class InscriptionStagiaireForm : Form
    {
        public InscriptionStagiaireForm()
        {
            InitializeComponent();
            listBoxFormation.SelectedIndex = 0;

        }

        private void textBoxNom_TextChanged(object sender, EventArgs e)
        {
            TextBox nom = (TextBox)sender;
            if (!Stagiaire.ValidateName(nom.Text))
            {
                this.errorProviderStagiaire.SetError(nom, "Le nom doit être de type Jean-Michel");
                return;
            }

            this.errorProviderStagiaire.SetError(nom, "");
        }


        private void textBoxDateDebut_TextChanged(object sender, EventArgs e)
        {
            TextBox dateToCheck = (TextBox)sender;
            if (!Stagiaire.ValidateDate(dateToCheck.Text))
            {
                this.errorProviderStagiaire.SetError(dateToCheck, "Format de date invalide.");
                return;
            }
            if (!Stagiaire.ValidateDate(textBoxDateDebut.Text) || !Stagiaire.ValidateDate(textBoxDateFin.Text))
            {
                this.errorProviderStagiaire.SetError(textBoxDateDebut, "Les deux dates de formations doivent être valides!");
                this.errorProviderStagiaire.SetError(textBoxDateFin, "Les deux dates de formations doivent être valides!");
                return;
            }
            this.errorProviderStagiaire.SetError(textBoxDateDebut, "");
            this.errorProviderStagiaire.SetError(textBoxDateFin, "");
            if (DateTime.ParseExact(textBoxDateDebut.Text, DateTimeFormatInfo.CurrentInfo.ShortDatePattern, CultureInfo.CurrentCulture) >= DateTime.ParseExact(textBoxDateFin.Text, DateTimeFormatInfo.CurrentInfo.ShortDatePattern, CultureInfo.CurrentCulture))
            {

                this.errorProviderStagiaire.SetError(dateToCheck, "Le début de la formation doit être avant la fin!");
                return;
            }
            this.errorProviderStagiaire.SetError(textBoxDateDebut, "");
            this.errorProviderStagiaire.SetError(textBoxDateFin, "");
        }

        private void listBoxFormation_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox listBox = (ListBox)sender;

            if (listBoxFormation.SelectedIndex == 0)
            {
                this.errorProviderStagiaire.SetError(listBox, "Choisissez une formation.");
                return;
            }
            this.errorProviderStagiaire.SetError(listBox, "");

        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            if (!Stagiaire.ValidateName(textBoxNom.Text) || !Stagiaire.ValidateName(textBoxPrenom.Text)
                || !Stagiaire.ValidateDate(textBoxDateDebut.Text) || !Stagiaire.ValidateDate(textBoxDateFin.Text)
                || listBoxFormation.SelectedIndex == 0
                || DateTime.ParseExact(textBoxDateDebut.Text, DateTimeFormatInfo.CurrentInfo.ShortDatePattern, CultureInfo.CurrentCulture) >= DateTime.ParseExact(textBoxDateFin.Text, DateTimeFormatInfo.CurrentInfo.ShortDatePattern, CultureInfo.CurrentCulture))
            {
                MessageBox.Show("Saisie Invalide, veuillez corriger les erreurs affichées",
                                "Saisie invalide",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Stagiaire stagiaire = new Stagiaire(textBoxNom.Text, textBoxPrenom.Text, DateTime.ParseExact(textBoxDateDebut.Text, DateTimeFormatInfo.CurrentInfo.ShortDatePattern, CultureInfo.CurrentCulture), DateTime.ParseExact(textBoxDateFin.Text, DateTimeFormatInfo.CurrentInfo.ShortDatePattern, CultureInfo.CurrentCulture), AffecterFormation(listBoxFormation.SelectedIndex));
            ConfirmationInscription formConfirm = new ConfirmationInscription(stagiaire);
            formConfirm.ShowDialog();
            this.Close();

        }

        public Formation AffecterFormation(int indexList)
        {
            switch (indexList)
            {
                case 1:
                    return Formation.CDA;
                case 2:
                    return Formation.DWWM;
                case 3:
                    return Formation.ABCDEV;
                default:
                    return Formation.Indetermine;
            }
        }
    }
}
