using System.ComponentModel;
using System.Windows.Forms;
using ToutEnBalles.Classes;

namespace bob
{
    public partial class TabCaisses : UserControl
    {
        Production prod;

        [Browsable(true)]
        public Production Prod
        {
            get => prod;
            set
            {
                prod = value;
                if (prod != null)
                {
                    this.Invoke(new UpdateUI(UpdateFields));
                }

            }

        }
        public TabCaisses()
        {
            InitializeComponent();
            this.textBoxnbCaisses.Text = "0";
            this.textBoxDefautHeure.Text = "0";
            this.textBoxDefautTotal.Text = "0";
        }

        delegate void UpdateUI();
        private void UpdateFields()
        {

            this.textBoxnbCaisses.Text = prod?.GetValidCrateNb().ToString();
            this.textBoxDefautHeure.Text = prod?.CalcLastHourFailureRate().ToString("0.0000");
            this.textBoxDefautTotal.Text = prod?.CalcTotalRealFailureRate().ToString("0.0000");

        }


    }
}
