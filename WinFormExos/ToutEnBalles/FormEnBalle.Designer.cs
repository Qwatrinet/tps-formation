using ToutEnBalles.Classes;

namespace ToutEnBalles
{
    partial class FormEnBalle
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.démarrerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arrêterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.continuerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelProgress = new System.Windows.Forms.Panel();
            this.panelAddProd = new System.Windows.Forms.Panel();
            this.buttonCreateProd = new System.Windows.Forms.Button();
            this.textBoxObjectif = new System.Windows.Forms.TextBox();
            this.textBoxTempsProd = new System.Windows.Forms.TextBox();
            this.labelObjectif = new System.Windows.Forms.Label();
            this.labelAddProd = new System.Windows.Forms.Label();
            this.NomProd = new System.Windows.Forms.Label();
            this.textBoxNomProd = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCaissesB = new bob.TabCaisses();
            this.tabCaissesC = new bob.TabCaisses();
            this.errorProviderAddProd = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip1.SuspendLayout();
            this.panelAddProd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAddProd)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.productionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // productionToolStripMenuItem
            // 
            this.productionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.démarrerToolStripMenuItem,
            this.arrêterToolStripMenuItem,
            this.continuerToolStripMenuItem});
            this.productionToolStripMenuItem.Name = "productionToolStripMenuItem";
            this.productionToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.productionToolStripMenuItem.Text = "Production";
            // 
            // démarrerToolStripMenuItem
            // 
            this.démarrerToolStripMenuItem.Name = "démarrerToolStripMenuItem";
            this.démarrerToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.démarrerToolStripMenuItem.Text = "Réinitialiser";
            // 
            // arrêterToolStripMenuItem
            // 
            this.arrêterToolStripMenuItem.Name = "arrêterToolStripMenuItem";
            this.arrêterToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.arrêterToolStripMenuItem.Text = "Suspendre";
            // 
            // continuerToolStripMenuItem
            // 
            this.continuerToolStripMenuItem.Name = "continuerToolStripMenuItem";
            this.continuerToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.continuerToolStripMenuItem.Text = "Continuer";
            // 
            // panelProgress
            // 
            this.panelProgress.AutoScroll = true;
            this.panelProgress.Location = new System.Drawing.Point(12, 247);
            this.panelProgress.Name = "panelProgress";
            this.panelProgress.Size = new System.Drawing.Size(776, 191);
            this.panelProgress.TabIndex = 8;
            // 
            // panelAddProd
            // 
            this.panelAddProd.Controls.Add(this.textBoxNomProd);
            this.panelAddProd.Controls.Add(this.NomProd);
            this.panelAddProd.Controls.Add(this.buttonCreateProd);
            this.panelAddProd.Controls.Add(this.textBoxObjectif);
            this.panelAddProd.Controls.Add(this.textBoxTempsProd);
            this.panelAddProd.Controls.Add(this.labelObjectif);
            this.panelAddProd.Controls.Add(this.labelAddProd);
            this.panelAddProd.Location = new System.Drawing.Point(24, 69);
            this.panelAddProd.Name = "panelAddProd";
            this.panelAddProd.Size = new System.Drawing.Size(314, 167);
            this.panelAddProd.TabIndex = 9;
            // 
            // buttonCreateProd
            // 
            this.buttonCreateProd.Location = new System.Drawing.Point(93, 119);
            this.buttonCreateProd.Name = "buttonCreateProd";
            this.buttonCreateProd.Size = new System.Drawing.Size(129, 33);
            this.buttonCreateProd.TabIndex = 4;
            this.buttonCreateProd.Text = "Ajouter une production";
            this.buttonCreateProd.UseVisualStyleBackColor = true;
            this.buttonCreateProd.Click += new System.EventHandler(this.buttonCreateProd_Click);
            // 
            // textBoxObjectif
            // 
            this.textBoxObjectif.Location = new System.Drawing.Point(192, 88);
            this.textBoxObjectif.Name = "textBoxObjectif";
            this.textBoxObjectif.Size = new System.Drawing.Size(100, 20);
            this.textBoxObjectif.TabIndex = 3;
            // 
            // textBoxTempsProd
            // 
            this.textBoxTempsProd.Location = new System.Drawing.Point(192, 52);
            this.textBoxTempsProd.Name = "textBoxTempsProd";
            this.textBoxTempsProd.Size = new System.Drawing.Size(100, 20);
            this.textBoxTempsProd.TabIndex = 2;
            // 
            // labelObjectif
            // 
            this.labelObjectif.AutoSize = true;
            this.labelObjectif.Location = new System.Drawing.Point(14, 95);
            this.labelObjectif.Name = "labelObjectif";
            this.labelObjectif.Size = new System.Drawing.Size(46, 13);
            this.labelObjectif.TabIndex = 1;
            this.labelObjectif.Text = "Objectif:";
            // 
            // labelAddProd
            // 
            this.labelAddProd.AutoSize = true;
            this.labelAddProd.Location = new System.Drawing.Point(14, 55);
            this.labelAddProd.Name = "labelAddProd";
            this.labelAddProd.Size = new System.Drawing.Size(172, 13);
            this.labelAddProd.TabIndex = 0;
            this.labelAddProd.Text = "Temps de production d\'une caisse:";
            // 
            // NomProd
            // 
            this.NomProd.AutoSize = true;
            this.NomProd.Location = new System.Drawing.Point(14, 19);
            this.NomProd.Name = "NomProd";
            this.NomProd.Size = new System.Drawing.Size(108, 13);
            this.NomProd.TabIndex = 5;
            this.NomProd.Text = "Nom de la production";
            // 
            // textBoxNomProd
            // 
            this.textBoxNomProd.Location = new System.Drawing.Point(192, 19);
            this.textBoxNomProd.Name = "textBoxNomProd";
            this.textBoxNomProd.Size = new System.Drawing.Size(100, 20);
            this.textBoxNomProd.TabIndex = 6;
            // 
            // tabControl1
            // 
            this.tabControl1.Location = new System.Drawing.Point(350, 73);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(374, 168);
            this.tabControl1.TabIndex = 1;
            // 
            // tabCaissesB
            // 
            this.tabCaissesB.Location = new System.Drawing.Point(0, 0);
            this.tabCaissesB.Name = "tabCaissesB";
            this.tabCaissesB.Prod = null;
            this.tabCaissesB.Size = new System.Drawing.Size(366, 142);
            this.tabCaissesB.TabIndex = 0;
            // 
            // tabCaissesC
            // 
            this.tabCaissesC.Location = new System.Drawing.Point(0, 0);
            this.tabCaissesC.Name = "tabCaissesC";
            this.tabCaissesC.Prod = null;
            this.tabCaissesC.Size = new System.Drawing.Size(366, 142);
            this.tabCaissesC.TabIndex = 0;
            // 
            // errorProviderAddProd
            // 
            this.errorProviderAddProd.ContainerControl = this;
            // 
            // FormEnBalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelAddProd);
            this.Controls.Add(this.panelProgress);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormEnBalle";
            this.Text = "Production des caisses";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormEnBalle_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelAddProd.ResumeLayout(false);
            this.panelAddProd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAddProd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productionToolStripMenuItem;
        private bob.TabCaisses tabCaissesB;
        private bob.TabCaisses tabCaissesC;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem démarrerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arrêterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem continuerToolStripMenuItem;
        private System.Windows.Forms.Panel panelProgress;
        private System.Windows.Forms.Panel panelAddProd;
        private System.Windows.Forms.Button buttonCreateProd;
        private System.Windows.Forms.TextBox textBoxObjectif;
        private System.Windows.Forms.TextBox textBoxTempsProd;
        private System.Windows.Forms.Label labelObjectif;
        private System.Windows.Forms.Label labelAddProd;
        private System.Windows.Forms.TextBox textBoxNomProd;
        private System.Windows.Forms.Label NomProd;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ErrorProvider errorProviderAddProd;
    }
}

