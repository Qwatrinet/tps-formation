using ComboListSpace;
using ControleDeSaisie;
using Couleurs;
using EmpruntsForm;
using GraouCalculateur;
using ListBoxForms;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuForm
{
    public partial class frmMenu : Form
    {
        private int nbAddi;
        public frmMenu()
        {
            InitializeComponent();
            nbAddi = 0;
        }

        public async void UpdateCountOpenWindows()
        {
            await Task.Delay(1);// c'est de la merde
            int nb = this.MdiChildren.Length;
            Debug.WriteLine(this.MdiChildren.Length);
            saisieToolStripMenuItem.Text = nb.ToString() + (nb > 1 ? " saisies" : " saisie");
        }

        private void LoginClick(object sender, System.EventArgs e)
        {
            MessageBox.Show("Salut les bouff!");
            phase1ToolStripMenuItem.Enabled = true;
            phase2ToolStripMenuItem.Enabled = true;
            phase3ToolStripMenuItem.Enabled = true;
            fenêtresToolStripMenuItem.Enabled = true;
            tsbPhase3.Enabled = true;
            sidentifierToolStripMenuItem.Enabled = false;
            identifierButton.Enabled = false;
            tsslDerniereOp.Text = "S'identifier";
            UpdateCountOpenWindows();
        }

        private void quitterToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void additionneurToolStripMenuItem_Click(object sender, System.EventArgs e)
        {

            //nbAddi++;
            Form f = new Form1
            {
                Text = $"L'Additionneur N°{++this.nbAddi}"
            };
            f.MdiParent = this;
            f.Show();
            tsslDerniereOp.Text = "Additionneur";

        }

        private void contrôlesToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Form f = new Controles();
            f.MdiParent = this;
            f.Show();
            tsslDerniereOp.Text = "Contrôles";

        }

        private void radiosToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Form f = new Saisie();
            f.MdiParent = this;
            f.Show();
            tsslDerniereOp.Text = "Radios";

        }

        private void listBoxToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Form f = new ListBoxForm();
            f.MdiParent = this;
            f.Show();
            tsslDerniereOp.Text = "ListBox";

        }

        private void défilementToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Form f = new CouleurForm();
            f.MdiParent = this;
            f.Show();
            tsslDerniereOp.Text = "Défilement";

        }

        private void comboBoxToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Form f = new ComboListForm();
            f.MdiParent = this;
            f.Show();
            tsslDerniereOp.Text = "Combo Box";

        }

        private void synthèseToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Form f = new LendingForm();
            f.MdiParent = this;
            f.Show();
            tsslDerniereOp.Text = "Synthèse";

        }

        private void cascadeToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
            tsslDerniereOp.Text = "Fenêtre Cascade";
        }

        private void horizontalToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
            tsslDerniereOp.Text = "Fenêtre Horizontale";
        }

        private void verticaleToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
            tsslDerniereOp.Text = "Fenêtre Verticale";
        }

        private void frmMenu_Load(object sender, System.EventArgs e)
        {
            tsslDate.Text = DateTime.Now.Date.ToString("dd/MM/yyyy");
            tsslDerniereOp.Text = "Bonjour";
            UpdateCountOpenWindows();
        }

        private void frmMenu_MdiChildActivate(object sender, EventArgs e)
        {
            UpdateCountOpenWindows();
        }
    }
}
