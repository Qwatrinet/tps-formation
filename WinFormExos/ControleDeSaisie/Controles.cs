using FormControlClass;
using System;
using System.Windows.Forms;

namespace ControleDeSaisie
{
    public partial class Controles : Form
    {
        public Controles()
        {
            InitializeComponent();
        }

        private void textBoxNom_TextChanged(object sender, EventArgs e)
        {
            TextBox nom = (TextBox)sender;
            if (!TransactionCheck.CheckNomValide(nom.Text))
            {
                this.errorProviderTransaction.SetError(nom, "Le nom doit être de type Bob.");
                return;
            }
            this.errorProviderTransaction.SetError(nom, "");
        }

        private void textBoxDate_TextChanged(object sender, EventArgs e)
        {
            TextBox dateToCheck = (TextBox)sender;
            if (!TransactionCheck.CheckDateValide(dateToCheck.Text))
            {
                this.errorProviderTransaction.SetError(dateToCheck, "Format de date invalide.");
                return;
            }
            this.errorProviderTransaction.SetError(dateToCheck, "");
        }

        private void textBoxMontant_TextChanged(object sender, EventArgs e)
        {
            TextBox montant = (TextBox)sender;
            if (!TransactionCheck.CheckMontantValide(montant.Text))
            {
                this.errorProviderTransaction.SetError(montant, "Le montant n'est pas un nombre!");
                return;
            }
            this.errorProviderTransaction.SetError(montant, "");

        }

        private void textBoxPostal_TextChanged(object sender, EventArgs e)
        {
            TextBox postal = (TextBox)sender;
            if (!TransactionCheck.CheckCodePostalValide(postal.Text))
            {
                this.errorProviderTransaction.SetError(postal, "Le code postal doit être de type 12345.");
                return;
            }
            this.errorProviderTransaction.SetError(postal, "");
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            if (!TransactionCheck.CheckDateValide(textBoxDate.Text)
                 || !TransactionCheck.CheckNomValide(textBoxNom.Text)
                 || !TransactionCheck.CheckMontantValide(textBoxMontant.Text)
                 || !TransactionCheck.CheckCodePostalValide(textBoxPostal.Text))
            {
                return;
            }
            Validation InfosForm = new Validation(textBoxNom.Text, textBoxDate.Text, textBoxMontant.Text, textBoxPostal.Text);
            DialogResult dr = InfosForm.ShowDialog();

            if (dr == DialogResult.OK)
            {
                textBoxDate.Clear();
                textBoxMontant.Clear();
                textBoxNom.Clear();
                textBoxPostal.Clear();
                this.errorProviderTransaction.Clear();
            }
        }

        private void buttonEffacer_Click(object sender, EventArgs e)
        {
            textBoxDate.Clear();
            textBoxMontant.Clear();
            textBoxNom.Clear();
            textBoxPostal.Clear();
            this.errorProviderTransaction.Clear();
        }

        private void Controles_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Fermer l'application",
                                "Fermer l'application?",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
