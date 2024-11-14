namespace MenuForm
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sidentifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phase1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.additionneurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phase2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contrôlesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phase3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radiosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.défilementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.synthèseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fenêtresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.saisieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.identifierButton = new System.Windows.Forms.ToolStripButton();
            this.tsbPhase3 = new System.Windows.Forms.ToolStripSplitButton();
            this.casesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBoxToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.défilementToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.synthèseToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslDerniereOp = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.phase1ToolStripMenuItem,
            this.phase2ToolStripMenuItem,
            this.phase3ToolStripMenuItem,
            this.fenêtresToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1116, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sidentifierToolStripMenuItem,
            this.toolStripSeparator3,
            this.quitterToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(81, 20);
            this.toolStripMenuItem1.Text = "Connection";
            // 
            // sidentifierToolStripMenuItem
            // 
            this.sidentifierToolStripMenuItem.Name = "sidentifierToolStripMenuItem";
            this.sidentifierToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.sidentifierToolStripMenuItem.Text = "S\'identifier";
            this.sidentifierToolStripMenuItem.Click += new System.EventHandler(this.LoginClick);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(127, 6);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // phase1ToolStripMenuItem
            // 
            this.phase1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.additionneurToolStripMenuItem});
            this.phase1ToolStripMenuItem.Enabled = false;
            this.phase1ToolStripMenuItem.Name = "phase1ToolStripMenuItem";
            this.phase1ToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.phase1ToolStripMenuItem.Text = "Phase 1";
            // 
            // additionneurToolStripMenuItem
            // 
            this.additionneurToolStripMenuItem.Name = "additionneurToolStripMenuItem";
            this.additionneurToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.additionneurToolStripMenuItem.Text = "Additionneur";
            this.additionneurToolStripMenuItem.Click += new System.EventHandler(this.additionneurToolStripMenuItem_Click);
            // 
            // phase2ToolStripMenuItem
            // 
            this.phase2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contrôlesToolStripMenuItem});
            this.phase2ToolStripMenuItem.Enabled = false;
            this.phase2ToolStripMenuItem.Name = "phase2ToolStripMenuItem";
            this.phase2ToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.phase2ToolStripMenuItem.Text = "Phase 2";
            // 
            // contrôlesToolStripMenuItem
            // 
            this.contrôlesToolStripMenuItem.Name = "contrôlesToolStripMenuItem";
            this.contrôlesToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.contrôlesToolStripMenuItem.Text = "Contrôles";
            this.contrôlesToolStripMenuItem.Click += new System.EventHandler(this.contrôlesToolStripMenuItem_Click);
            // 
            // phase3ToolStripMenuItem
            // 
            this.phase3ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.radiosToolStripMenuItem,
            this.listBoxToolStripMenuItem,
            this.comboBoxToolStripMenuItem,
            this.défilementToolStripMenuItem,
            this.toolStripSeparator1,
            this.synthèseToolStripMenuItem});
            this.phase3ToolStripMenuItem.Enabled = false;
            this.phase3ToolStripMenuItem.Name = "phase3ToolStripMenuItem";
            this.phase3ToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.phase3ToolStripMenuItem.Text = "Phase 3";
            // 
            // radiosToolStripMenuItem
            // 
            this.radiosToolStripMenuItem.Name = "radiosToolStripMenuItem";
            this.radiosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.radiosToolStripMenuItem.Text = "Radios";
            this.radiosToolStripMenuItem.Click += new System.EventHandler(this.radiosToolStripMenuItem_Click);
            // 
            // listBoxToolStripMenuItem
            // 
            this.listBoxToolStripMenuItem.Name = "listBoxToolStripMenuItem";
            this.listBoxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listBoxToolStripMenuItem.Text = "ListBox";
            this.listBoxToolStripMenuItem.Click += new System.EventHandler(this.listBoxToolStripMenuItem_Click);
            // 
            // comboBoxToolStripMenuItem
            // 
            this.comboBoxToolStripMenuItem.Name = "comboBoxToolStripMenuItem";
            this.comboBoxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.comboBoxToolStripMenuItem.Text = "ComboBox";
            this.comboBoxToolStripMenuItem.Click += new System.EventHandler(this.comboBoxToolStripMenuItem_Click);
            // 
            // défilementToolStripMenuItem
            // 
            this.défilementToolStripMenuItem.Name = "défilementToolStripMenuItem";
            this.défilementToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.défilementToolStripMenuItem.Text = "Défilement";
            this.défilementToolStripMenuItem.Click += new System.EventHandler(this.défilementToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // synthèseToolStripMenuItem
            // 
            this.synthèseToolStripMenuItem.Name = "synthèseToolStripMenuItem";
            this.synthèseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.synthèseToolStripMenuItem.Text = "Synthèse";
            this.synthèseToolStripMenuItem.Click += new System.EventHandler(this.synthèseToolStripMenuItem_Click);
            // 
            // fenêtresToolStripMenuItem
            // 
            this.fenêtresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascadeToolStripMenuItem,
            this.horizontalToolStripMenuItem,
            this.verticaleToolStripMenuItem,
            this.toolStripSeparator2,
            this.saisieToolStripMenuItem});
            this.fenêtresToolStripMenuItem.Enabled = false;
            this.fenêtresToolStripMenuItem.Name = "fenêtresToolStripMenuItem";
            this.fenêtresToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.fenêtresToolStripMenuItem.Text = "Fenêtres";
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.cascadeToolStripMenuItem.Text = "Cascade";
            this.cascadeToolStripMenuItem.Click += new System.EventHandler(this.cascadeToolStripMenuItem_Click);
            // 
            // horizontalToolStripMenuItem
            // 
            this.horizontalToolStripMenuItem.Name = "horizontalToolStripMenuItem";
            this.horizontalToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.horizontalToolStripMenuItem.Text = "Horizontal";
            this.horizontalToolStripMenuItem.Click += new System.EventHandler(this.horizontalToolStripMenuItem_Click);
            // 
            // verticaleToolStripMenuItem
            // 
            this.verticaleToolStripMenuItem.Name = "verticaleToolStripMenuItem";
            this.verticaleToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.verticaleToolStripMenuItem.Text = "Verticale";
            this.verticaleToolStripMenuItem.Click += new System.EventHandler(this.verticaleToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(126, 6);
            // 
            // saisieToolStripMenuItem
            // 
            this.saisieToolStripMenuItem.Name = "saisieToolStripMenuItem";
            this.saisieToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.saisieToolStripMenuItem.Text = "Saisie";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.identifierButton,
            this.tsbPhase3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1116, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // identifierButton
            // 
            this.identifierButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.identifierButton.Image = ((System.Drawing.Image)(resources.GetObject("identifierButton.Image")));
            this.identifierButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.identifierButton.Name = "identifierButton";
            this.identifierButton.Size = new System.Drawing.Size(67, 22);
            this.identifierButton.Text = "S\'identifier";
            this.identifierButton.Click += new System.EventHandler(this.LoginClick);
            // 
            // tsbPhase3
            // 
            this.tsbPhase3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbPhase3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.casesToolStripMenuItem,
            this.comboBoxToolStripMenuItem1,
            this.défilementToolStripMenuItem1,
            this.toolStripSeparator4,
            this.synthèseToolStripMenuItem1});
            this.tsbPhase3.Enabled = false;
            this.tsbPhase3.Image = ((System.Drawing.Image)(resources.GetObject("tsbPhase3.Image")));
            this.tsbPhase3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPhase3.Name = "tsbPhase3";
            this.tsbPhase3.Size = new System.Drawing.Size(60, 22);
            this.tsbPhase3.Text = "Phase3";
            // 
            // casesToolStripMenuItem
            // 
            this.casesToolStripMenuItem.Name = "casesToolStripMenuItem";
            this.casesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.casesToolStripMenuItem.Text = "Radios";
            this.casesToolStripMenuItem.Click += new System.EventHandler(this.radiosToolStripMenuItem_Click);
            // 
            // comboBoxToolStripMenuItem1
            // 
            this.comboBoxToolStripMenuItem1.Name = "comboBoxToolStripMenuItem1";
            this.comboBoxToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.comboBoxToolStripMenuItem1.Text = "ComboBox";
            this.comboBoxToolStripMenuItem1.Click += new System.EventHandler(this.comboBoxToolStripMenuItem_Click);
            // 
            // défilementToolStripMenuItem1
            // 
            this.défilementToolStripMenuItem1.Name = "défilementToolStripMenuItem1";
            this.défilementToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.défilementToolStripMenuItem1.Text = "Défilement";
            this.défilementToolStripMenuItem1.Click += new System.EventHandler(this.défilementToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(177, 6);
            // 
            // synthèseToolStripMenuItem1
            // 
            this.synthèseToolStripMenuItem1.Name = "synthèseToolStripMenuItem1";
            this.synthèseToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.synthèseToolStripMenuItem1.Text = "Synthèse";
            this.synthèseToolStripMenuItem1.Click += new System.EventHandler(this.synthèseToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslDate,
            this.tsslDerniereOp});
            this.statusStrip1.Location = new System.Drawing.Point(0, 639);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1116, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslDate
            // 
            this.tsslDate.Name = "tsslDate";
            this.tsslDate.Size = new System.Drawing.Size(71, 17);
            this.tsslDate.Text = "date du jour";
            // 
            // tsslDerniereOp
            // 
            this.tsslDerniereOp.Name = "tsslDerniereOp";
            this.tsslDerniereOp.Size = new System.Drawing.Size(64, 17);
            this.tsslDerniereOp.Text = "derniereop";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 661);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "frmMenu";
            this.Text = "Créer des formulaires";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.MdiChildActivate += new System.EventHandler(this.frmMenu_MdiChildActivate);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem phase1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem additionneurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phase2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contrôlesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phase3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem radiosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comboBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem défilementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fenêtresToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem synthèseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verticaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem saisieToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton identifierButton;
        private System.Windows.Forms.ToolStripMenuItem sidentifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton tsbPhase3;
        private System.Windows.Forms.ToolStripMenuItem casesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comboBoxToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem défilementToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem synthèseToolStripMenuItem1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslDate;
        private System.Windows.Forms.ToolStripStatusLabel tsslDerniereOp;
        private System.Windows.Forms.Timer timer1;
    }
}

