using System.ComponentModel;
using System.Windows.Forms;
using ToutEnBalles.Classes;

namespace bob
{
    public partial class ProdBar : UserControl
    {
        private Production prod;
        private string textProd;
        [Browsable(true)]
        public string TextProd { get => textProd; set => textProd = value; }
        [Browsable(true)]
        public Production Prod
        {
            get => prod;
            set
            {
                prod = value;
                if (prod != null)
                {
                    this.Invoke(new UpdateProgress(Progress));
                }

            }

        }
        delegate void UpdateProgress();
        public ProdBar()
        {
            InitializeComponent();
        }

        public Timer ProdTimer => this.timerProd;

        private void ProdBar_Load(object sender, System.EventArgs e)
        {
            this.labelProd.Text = this.TextProd;
        }

        private void Progress()
        {
            this.progressBar1.Value = this.prod?.GetProgression() ?? 0;
        }
    }
}
