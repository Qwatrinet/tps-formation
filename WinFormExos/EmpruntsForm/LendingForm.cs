using BankLibrary;
using FormControlClass;
using System;
using System.Windows.Forms;

namespace EmpruntsForm
{
    public partial class LendingForm : Form
    {
        private Loan loan;

        public Loan Loan { get => loan; }

        public LendingForm() : this(new Loan())
        {
            //InitializeComponent();
            //this.loan = new Loan();
            //listBoxPeriod.SelectedIndex = 0;
            //UpdatePaymentUI();

        }

        public LendingForm(Loan loan)
        {
            InitializeComponent();
            this.loan = new Loan(loan);
            UpdateStaticUI();
            //listBoxPeriod.SelectedIndex = loan.PeriodBetweenPayments switch
            //{
            //    1 => 4,
            //    2 => 3,
            //    4 => 2,
            //    6 => 1,
            //    12 => 0,
            //    _ => listBoxPeriod.SelectedIndex
            //};
            UpdatePaymentUI();
        }

        private void UpdateStaticUI()
        {
            textBoxNom.Text = loan.Name;
            textBoxCapital.Text = loan.AmountLent.ToString();
            hScrollBarDuree.Value = loan.Duration;
            switch (loan.PeriodBetweenPayments)
            {
                case 1:
                    listBoxPeriod.SelectedIndex = 0;
                    break;
                case 2:
                    listBoxPeriod.SelectedIndex = 1;
                    break;
                case 3:
                    listBoxPeriod.SelectedIndex = 2;
                    break;
                case 6:
                    listBoxPeriod.SelectedIndex = 3;
                    break;
                default:
                    listBoxPeriod.SelectedIndex = 4;
                    break;
            }
            switch (loan.Interests)
            {
                case 7:
                    radioButton7.Checked = true;
                    break;
                case 8:
                    radioButton8.Checked = true;
                    break;
                default:
                    radioButton9.Checked = true;
                    break;
            }
        }
        private void UpdatePaymentUI()
        {
            labelNbRembours.Text = loan.CalcNumberPayments().ToString();
            labelMontant.Text = loan.CalcPayments().ToString();
        }

        private void UpdateScrollbarConstraints()
        {

            switch (listBoxPeriod.SelectedIndex)
            {
                case 0:
                    hScrollBarDuree.Minimum = 1;
                    hScrollBarDuree.Maximum = 150;
                    hScrollBarDuree.SmallChange = 1;
                    hScrollBarDuree.LargeChange = 1;
                    break;
                case 1:
                    hScrollBarDuree.Minimum = 2;
                    hScrollBarDuree.Maximum = 151;
                    hScrollBarDuree.SmallChange = 2;
                    hScrollBarDuree.LargeChange = 2;
                    hScrollBarDuree.Value = hScrollBarDuree.Value % 2 == 0 ? hScrollBarDuree.Value : hScrollBarDuree.Value - 1;
                    this.loan.Duration = hScrollBarDuree.Value;
                    dureeValue.Text = this.loan.Duration.ToString();

                    break;
                case 2:
                    hScrollBarDuree.Minimum = 3;
                    hScrollBarDuree.Maximum = 152;
                    hScrollBarDuree.LargeChange = 3;
                    hScrollBarDuree.SmallChange = 3;
                    while (hScrollBarDuree.Value % 3 != 0)
                    {
                        hScrollBarDuree.Value -= 1;
                    }
                    this.loan.Duration = hScrollBarDuree.Value;
                    dureeValue.Text = this.loan.Duration.ToString();
                    break;
                case 3:
                    hScrollBarDuree.Minimum = 6;
                    hScrollBarDuree.Maximum = 155;
                    hScrollBarDuree.SmallChange = 6;
                    hScrollBarDuree.LargeChange = 6;
                    while (hScrollBarDuree.Value % 6 != 0)
                    {
                        hScrollBarDuree.Value -= 1;
                    }
                    this.loan.Duration = hScrollBarDuree.Value;
                    dureeValue.Text = this.loan.Duration.ToString();
                    break;
                case 4:
                    hScrollBarDuree.Minimum = 12;
                    hScrollBarDuree.Maximum = 156;
                    hScrollBarDuree.LargeChange = 12;
                    hScrollBarDuree.SmallChange = 12;
                    while (hScrollBarDuree.Value % 12 != 0)
                    {
                        hScrollBarDuree.Value -= 1;
                    }
                    this.loan.Duration = hScrollBarDuree.Value;
                    dureeValue.Text = this.loan.Duration.ToString();
                    break;
            }
        }
        private void textBoxNom_Leave(object sender, EventArgs e)
        {
            if (textBoxNom.Text.Length == 0)
            {
                this.loan.Name = textBoxNom.Text;
                this.errorProviderLoan.SetError(labelNom, "");
                return;
            }
            if (!TransactionCheck.CheckNomValide(textBoxNom.Text))
            {
                this.errorProviderLoan.SetError(labelNom, "Le nom doit être de type Bob ou Jean-Michel.");
                return;
            }
            this.errorProviderLoan.SetError(labelNom, "");
            this.loan.Name = textBoxNom.Text;
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            this.loan.Duration = hScrollBarDuree.Value;
            dureeValue.Text = this.loan.Duration.ToString();
            UpdateScrollbarConstraints();
            UpdatePaymentUI();
        }

        private void textBoxCapital_TextChanged(object sender, EventArgs e)
        {
            if (!TransactionCheck.CheckIntValid(textBoxCapital.Text))
            {
                this.errorProviderLoan.SetError(labelCapital, "Le montant doit être un nombre positif.");
                return;
            }
            this.errorProviderLoan.SetError(labelCapital, "");
            this.loan.AmountLent = int.Parse(textBoxCapital.Text);
            UpdatePaymentUI();

        }

        private void listBoxPeriod_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listBoxPeriod.SelectedIndex)
            {
                case 0:
                    this.loan.PeriodBetweenPayments = 1;
                    break;
                case 1:
                    this.loan.PeriodBetweenPayments = 2;
                    break;
                case 2:
                    this.loan.PeriodBetweenPayments = 3;
                    break;
                case 3:
                    this.loan.PeriodBetweenPayments = 6;
                    break;
                default:
                    this.loan.PeriodBetweenPayments = 12;
                    break;
            }
            UpdateScrollbarConstraints();
            UpdatePaymentUI();
        }

        private void interestButton_Changed(object sender, EventArgs e)
        {
            if (!((RadioButton)sender).Checked)
            {
                return;
            }
            this.loan.Interests = int.Parse(((RadioButton)sender).Tag.ToString());
            UpdatePaymentUI();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.loan = new Loan();
            UpdateScrollbarConstraints();
            UpdateStaticUI();
            UpdatePaymentUI();
        }
    }
}
