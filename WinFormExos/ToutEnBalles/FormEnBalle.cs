using bob;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using ToutEnBalles.Classes;

namespace ToutEnBalles
{
    public partial class FormEnBalle : Form
    {
        private List<Production> productions;
        public FormEnBalle()
        {
            InitializeComponent();
            productions = new List<Production>();
        }

        private void buttonCreateProd_Click(object sender, EventArgs e)
        {
            if (!checkNbValide(textBoxTempsProd.Text))
            {
                this.errorProviderAddProd.SetError(textBoxTempsProd, "Ce nombre doit être positif.");
                return;
            }
            if (!checkNbValide(textBoxObjectif.Text))
            {
                this.errorProviderAddProd.SetError(textBoxObjectif, "Ce nombre doit être positif.");
                return;
            }
            if (textBoxNomProd.Text.Length == 0)
            {
                this.errorProviderAddProd.SetError(textBoxNomProd, "Il faut entrer un nom!");
                return;
            }
            this.errorProviderAddProd.SetError(textBoxTempsProd, "");
            this.errorProviderAddProd.SetError(textBoxObjectif, "");
            this.errorProviderAddProd.SetError(textBoxNomProd, "");
            bool bTProd = int.TryParse(textBoxTempsProd.Text, out int tProd);
            bool bGoal = int.TryParse(textBoxObjectif.Text, out int goal);
            Production prod = new Production(textBoxNomProd.Text, goal, tProd);
            this.productions.Add(prod);

            ProdBar prodBar = new bob.ProdBar();
            prodBar.Dock = System.Windows.Forms.DockStyle.Top;
            prodBar.Location = new System.Drawing.Point(0, 0);
            prodBar.Name = "prodBar" + prod.TypeProd;
            prodBar.Prod = null;
            prodBar.Size = new System.Drawing.Size(776, 47);
            prodBar.Tag = prod.TypeProd;
            prodBar.TextProd = "Production " + prod.TypeProd;
            prodBar.Load += new System.EventHandler(this.prodBarComponent_Load);
            panelProgress.Controls.Add(prodBar);

            TabCaisses tabCaisses = new TabCaisses();
            TabPage tabPage = new TabPage();

            this.tabControl1.Controls.Add(tabPage);
            tabPage.Controls.Add(tabCaisses);
            tabPage.Location = new System.Drawing.Point(4, 22);
            tabPage.Name = "tabPageType" + prod.TypeProd;
            tabPage.Padding = new System.Windows.Forms.Padding(3);
            tabPage.Size = new System.Drawing.Size(366, 142);
            tabPage.Text = "Type" + prod.TypeProd;
            tabPage.UseVisualStyleBackColor = true;

            tabCaisses.Location = new System.Drawing.Point(0, 0);
            tabCaisses.Name = "tabCaisses" + prod.TypeProd;
            tabCaisses.Prod = null;
            tabCaisses.Size = new System.Drawing.Size(366, 142);
            tabCaisses.Load += new System.EventHandler(this.tabCaissesComponent_Load);

            ToolStripMenuItem ItemResume = new ToolStripMenuItem();
            this.continuerToolStripMenuItem.DropDownItems.Add(ItemResume);
            ItemResume.Name = prod.TypeProd + "ToolStripMenuItemContinuer";
            ItemResume.Size = new System.Drawing.Size(82, 22);
            ItemResume.Text = prod.TypeProd;
            ItemResume.Click += new System.EventHandler(this.Continuer_Click);
            ItemResume.Tag = prod;
            ItemResume.Enabled = false;

            ToolStripMenuItem ItemStop = new ToolStripMenuItem();
            this.arrêterToolStripMenuItem.DropDownItems.Add(ItemStop);
            ItemStop.Name = prod.TypeProd + "ToolStripMenuItemStop";
            ItemStop.Size = new System.Drawing.Size(82, 22);
            ItemStop.Text = prod.TypeProd;
            ItemStop.Click += new System.EventHandler(this.StopProd_Click);
            ItemStop.Tag = prod.TypeProd;
            ItemStop.Enabled = false;

            ToolStripMenuItem ItemStart = new ToolStripMenuItem();
            this.démarrerToolStripMenuItem.DropDownItems.Add(ItemStart);
            ItemStart.Name = prod.TypeProd + "ToolStripMenuItemDem";
            ItemStart.Size = new System.Drawing.Size(82, 22);
            ItemStart.Text = prod.TypeProd;
            ItemStart.Click += new System.EventHandler(this.DemarrerProd_Click);
            ItemStart.Tag = prod;

            textBoxNomProd.Clear();
            textBoxObjectif.Clear();
            textBoxTempsProd.Clear();
        }

        private void prodBarComponent_Load(object sender, EventArgs e)
        {
            ((ProdBar)sender).Prod = this.productions[this.productions.Count - 1];
        }

        private void tabCaissesComponent_Load(object sender, EventArgs e)
        {
            ((TabCaisses)sender).Prod = this.productions[this.productions.Count - 1];
        }




        private TabCaisses GetTabCaissesFromType(string type)
        {
            return (TabCaisses)this.tabControl1.Controls.Find("tabCaisses" + type, true)[0];
        }
        private ProdBar GetProdBarFromType(string type)
        {
            return (ProdBar)this.panelProgress.Controls.Find("prodBar" + type, false)[0];
        }

        private ToolStripItem GetRestartButtonFromType(string type)
        {
            return this.menuStrip1.Items.Find(type + "ToolStripMenuItemDem", true)[0];
        }

        private ToolStripItem GetResumeButtonFromType(string type)
        {
            return this.menuStrip1.Items.Find(type + "ToolStripMenuItemContinuer", true)[0];
        }

        private ToolStripItem GetInterruptButtonFromType(string type)
        {
            return this.menuStrip1.Items.Find(type + "ToolStripMenuItemStop", true)[0];
        }

        //Toolbar items
        private void StartProd(Production prod)
        {
            prod.StartProd();
            ProdBar prodbar = GetProdBarFromType(prod.TypeProd);
            prod.prodEvent += new Production.CrateProducedEventHandler(UpdateUI);
            prod.prodStateChanged += new Production.ProdStateChangedEventHandler(ChangeStateUI);
        }

        private void ChangeStateUI(Production prod)
        {
            if (prod.ProdState == ProdState.Termine)
            {
                ProdFinished(prod);
            }
        }
        private void UpdateUI(Production prod)
        {
            CreateCrate(prod);

        }
        private void StopProd(Production prod)
        {
            prod.SuspendProd();

        }

        private void ResetProd(Production prod)
        {
            //GetRestartButtonFromType(prod.TypeProd).Tag = prod;
            this.Invoke(new ChangeProd(CreateTagRestartButton), new object[] { prod });
            //GetResumeButtonFromType(prod.TypeProd).Tag = prod;
            this.Invoke(new ChangeProd(CreateTagResumeButton), new object[] { prod });
            //GetProdBarFromType(prod.TypeProd).Tag = prod;
            this.Invoke(new ChangeProd(CreateTagProdBar), new object[] { prod });
            //GetTabCaissesFromType(prod.TypeProd).Tag = prod;
            this.Invoke(new ChangeProd(CreateTagTabCaisses), new object[] { prod });
            //GetInterruptButtonFromType(prod.TypeProd).Tag = prod;
            this.Invoke(new ChangeProd(CreateTagInterruptButton), new object[] { prod });
            int i = this.productions.FindIndex(p => p.TypeProd == prod.TypeProd);
            this.productions.RemoveAt(i);
            this.productions.Insert(i, prod);
        }
        private void DemarrerProd_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem pouic = (ToolStripMenuItem)sender;
            Production prod = (Production)pouic.Tag;
            prod = new Production(prod);
            ResetProd(prod);
            this.StartProd(prod);
            pouic.Enabled = false;
            //GetInterruptButtonFromType(prod.TypeProd).Enabled = true;
            this.Invoke(new ChangeEnable(ChangeInterruptButtonState), new object[] { prod, true });

        }

        private void StopProd_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem pouic = (ToolStripMenuItem)sender;
            Production prod = (Production)pouic.Tag;
            this.StopProd(prod);
            pouic.Enabled = false;
            //GetResumeButtonFromType(prod.TypeProd).Enabled = true;
            ((ToolStripItem)(this.Invoke(new bob<ToolStripItem>(GetResumeButtonFromType), new object[] { prod.TypeProd }))).Enabled = true;
        }

        private void Continuer_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem pouic = (ToolStripMenuItem)sender;
            Production prod = (Production)pouic.Tag;
            this.StartProd(prod);
            pouic.Enabled = false;
            //GetInterruptButtonFromType(prod.TypeProd).Enabled = true;
            this.Invoke(new ChangeEnable(ChangeInterruptButtonState), new object[] { prod, true });
        }

        private void ProdFinished(Production prod)
        {
            StopProd(prod);
            //GetInterruptButtonFromType(prod.TypeProd).Enabled = false;
            this.Invoke(new ChangeEnable(ChangeInterruptButtonState), new object[] { prod, false });
            //GetRestartButtonFromType(prod.TypeProd).Enabled = true;
            this.Invoke(new ChangeEnable(ChangeRestartButtonState), new object[] { prod, true });

        }

        private void CreateCrate(Production prod)
        {
            try
            {
                //GetProdBarFromType(prod.TypeProd).Prod = prod;
                this.Invoke(new ChangeProd(RefreshProdTabCaisses), new object[] { prod });
                //GetTabCaissesFromType(prod.TypeProd).Prod = prod;
                this.Invoke(new ChangeProd(RefreshProdProdBar), new object[] { prod });
            }
            catch (ObjectDisposedException e)
            {

            }

        }

        #region Jaraxxus 
        private delegate void ChangeEnable(Production prod, bool b);
        private delegate void ChangeProd(Production prod);
        public delegate T bob<T>(string type);

        private void ChangeInterruptButtonState(Production prod, bool b)
        {
            GetInterruptButtonFromType(prod.TypeProd).Enabled = b;
        }

        private void ChangeRestartButtonState(Production prod, bool b)
        {
            GetRestartButtonFromType(prod.TypeProd).Enabled = b;
        }

        private void ChangeResumeButtonState(Production prod, bool b)
        {
            GetResumeButtonFromType(prod.TypeProd).Enabled = b;
        }

        private void RefreshProdProdBar(Production prod)
        {
            GetProdBarFromType(prod.TypeProd).Prod = prod;
        }

        private void RefreshProdTabCaisses(Production prod)
        {
            GetTabCaissesFromType(prod.TypeProd).Prod = prod;
        }

        private void CreateTagInterruptButton(Production prod)
        {
            GetInterruptButtonFromType(prod.TypeProd).Tag = prod;
        }

        private void CreateTagResumeButton(Production prod)
        {
            GetResumeButtonFromType(prod.TypeProd).Tag = prod;
        }

        private void CreateTagRestartButton(Production prod)
        {
            GetRestartButtonFromType(prod.TypeProd).Tag = prod;
        }

        private void CreateTagTabCaisses(Production prod)
        {
            GetTabCaissesFromType(prod.TypeProd).Tag = prod;
        }

        private void CreateTagProdBar(Production prod)
        {
            GetProdBarFromType(prod.TypeProd).Tag = prod;
        }
        #endregion

        private void FormEnBalle_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (Production prod in productions)
            {
                prod.SuspendProd();
                prod.prodEvent -= new Production.CrateProducedEventHandler(UpdateUI);
            }
            //e.Cancel = true;
            //this.FormClosing -= FormEnBalle_FormClosing;
            Thread.Sleep(10);
            //this.Close();
        }

        public bool checkNbValide(string nb)
        {
            //Regex myRegex = new Regex(@"^[0-9]+(?:[.,][0-9]+)?$");
            return int.TryParse(nb, out int number) && number > 0;
        }


        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

