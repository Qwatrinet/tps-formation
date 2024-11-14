namespace EmpruntsForm
{
    partial class LendingForm
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
            this.labelNom = new System.Windows.Forms.Label();
            this.labelCapital = new System.Windows.Forms.Label();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxCapital = new System.Windows.Forms.TextBox();
            this.labelDuree = new System.Windows.Forms.Label();
            this.hScrollBarDuree = new System.Windows.Forms.HScrollBar();
            this.dureeValue = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.labelPeriode = new System.Windows.Forms.Label();
            this.listBoxPeriod = new System.Windows.Forms.ListBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelRembours = new System.Windows.Forms.Label();
            this.labelNbRembours = new System.Windows.Forms.Label();
            this.labelMontant = new System.Windows.Forms.Label();
            this.errorProviderLoan = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLoan)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(83, 81);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(29, 13);
            this.labelNom.TabIndex = 0;
            this.labelNom.Text = "Nom";
            // 
            // labelCapital
            // 
            this.labelCapital.AutoSize = true;
            this.labelCapital.Location = new System.Drawing.Point(83, 121);
            this.labelCapital.Name = "labelCapital";
            this.labelCapital.Size = new System.Drawing.Size(87, 13);
            this.labelCapital.TabIndex = 1;
            this.labelCapital.Text = "Capital Emprunté";
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(198, 81);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(100, 20);
            this.textBoxNom.TabIndex = 2;
            this.textBoxNom.Leave += new System.EventHandler(this.textBoxNom_Leave);
            // 
            // textBoxCapital
            // 
            this.textBoxCapital.Location = new System.Drawing.Point(198, 121);
            this.textBoxCapital.Name = "textBoxCapital";
            this.textBoxCapital.Size = new System.Drawing.Size(100, 20);
            this.textBoxCapital.TabIndex = 3;
            this.textBoxCapital.TextChanged += new System.EventHandler(this.textBoxCapital_TextChanged);
            // 
            // labelDuree
            // 
            this.labelDuree.AutoSize = true;
            this.labelDuree.Location = new System.Drawing.Point(83, 176);
            this.labelDuree.Name = "labelDuree";
            this.labelDuree.Size = new System.Drawing.Size(165, 13);
            this.labelDuree.TabIndex = 4;
            this.labelDuree.Text = "Durée en mois du remboursement";
            // 
            // hScrollBarDuree
            // 
            this.hScrollBarDuree.Location = new System.Drawing.Point(323, 176);
            this.hScrollBarDuree.Maximum = 160;
            this.hScrollBarDuree.Minimum = 1;
            this.hScrollBarDuree.Name = "hScrollBarDuree";
            this.hScrollBarDuree.Size = new System.Drawing.Size(151, 13);
            this.hScrollBarDuree.TabIndex = 5;
            this.hScrollBarDuree.Value = 1;
            this.hScrollBarDuree.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // dureeValue
            // 
            this.dureeValue.AutoSize = true;
            this.dureeValue.Location = new System.Drawing.Point(275, 176);
            this.dureeValue.Name = "dureeValue";
            this.dureeValue.Size = new System.Drawing.Size(13, 13);
            this.dureeValue.TabIndex = 6;
            this.dureeValue.Text = "1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton9);
            this.groupBox1.Controls.Add(this.radioButton8);
            this.groupBox1.Controls.Add(this.radioButton7);
            this.groupBox1.Location = new System.Drawing.Point(497, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(103, 149);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Taux d\'intérêt";
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point(29, 110);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(39, 17);
            this.radioButton9.TabIndex = 2;
            this.radioButton9.Tag = "9";
            this.radioButton9.Text = "9%";
            this.radioButton9.UseVisualStyleBackColor = true;
            this.radioButton9.CheckedChanged += new System.EventHandler(this.interestButton_Changed);
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(29, 64);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(39, 17);
            this.radioButton8.TabIndex = 1;
            this.radioButton8.Tag = "8";
            this.radioButton8.Text = "8%";
            this.radioButton8.UseVisualStyleBackColor = true;
            this.radioButton8.CheckedChanged += new System.EventHandler(this.interestButton_Changed);
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Checked = true;
            this.radioButton7.Location = new System.Drawing.Point(29, 19);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(39, 17);
            this.radioButton7.TabIndex = 0;
            this.radioButton7.TabStop = true;
            this.radioButton7.Tag = "7";
            this.radioButton7.Text = "7%";
            this.radioButton7.UseVisualStyleBackColor = true;
            this.radioButton7.CheckedChanged += new System.EventHandler(this.interestButton_Changed);
            // 
            // labelPeriode
            // 
            this.labelPeriode.AutoSize = true;
            this.labelPeriode.Location = new System.Drawing.Point(83, 245);
            this.labelPeriode.Name = "labelPeriode";
            this.labelPeriode.Size = new System.Drawing.Size(146, 13);
            this.labelPeriode.TabIndex = 8;
            this.labelPeriode.Text = "Périodicité de remboursement";
            // 
            // listBoxPeriod
            // 
            this.listBoxPeriod.FormattingEnabled = true;
            this.listBoxPeriod.Items.AddRange(new object[] {
            "Mensuelle",
            "Bimestrielle",
            "Trimestrielle",
            "Semestrielle",
            "Annuelle"});
            this.listBoxPeriod.Location = new System.Drawing.Point(86, 277);
            this.listBoxPeriod.Name = "listBoxPeriod";
            this.listBoxPeriod.Size = new System.Drawing.Size(241, 69);
            this.listBoxPeriod.TabIndex = 9;
            this.listBoxPeriod.TabStop = false;
            this.listBoxPeriod.SelectedIndexChanged += new System.EventHandler(this.listBoxPeriod_SelectedIndexChanged);
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(667, 94);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 10;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(667, 139);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "Annuler";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelRembours
            // 
            this.labelRembours.AutoSize = true;
            this.labelRembours.Location = new System.Drawing.Point(555, 287);
            this.labelRembours.Name = "labelRembours";
            this.labelRembours.Size = new System.Drawing.Size(89, 13);
            this.labelRembours.TabIndex = 12;
            this.labelRembours.Text = "Remboursements";
            // 
            // labelNbRembours
            // 
            this.labelNbRembours.AutoSize = true;
            this.labelNbRembours.ForeColor = System.Drawing.Color.Red;
            this.labelNbRembours.Location = new System.Drawing.Point(494, 287);
            this.labelNbRembours.Name = "labelNbRembours";
            this.labelNbRembours.Size = new System.Drawing.Size(13, 13);
            this.labelNbRembours.TabIndex = 13;
            this.labelNbRembours.Text = "0";
            // 
            // labelMontant
            // 
            this.labelMontant.AutoSize = true;
            this.labelMontant.ForeColor = System.Drawing.Color.Red;
            this.labelMontant.Location = new System.Drawing.Point(582, 333);
            this.labelMontant.Name = "labelMontant";
            this.labelMontant.Size = new System.Drawing.Size(22, 13);
            this.labelMontant.TabIndex = 14;
            this.labelMontant.Text = "0 €";
            this.labelMontant.Click += new System.EventHandler(this.interestButton_Changed);
            // 
            // errorProviderLoan
            // 
            this.errorProviderLoan.ContainerControl = this;
            // 
            // LendingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelMontant);
            this.Controls.Add(this.labelNbRembours);
            this.Controls.Add(this.labelRembours);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.listBoxPeriod);
            this.Controls.Add(this.labelPeriode);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dureeValue);
            this.Controls.Add(this.hScrollBarDuree);
            this.Controls.Add(this.labelDuree);
            this.Controls.Add(this.textBoxCapital);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.labelCapital);
            this.Controls.Add(this.labelNom);
            this.Name = "LendingForm";
            this.Text = "Emprunts";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLoan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelCapital;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxCapital;
        private System.Windows.Forms.Label labelDuree;
        private System.Windows.Forms.HScrollBar hScrollBarDuree;
        private System.Windows.Forms.Label dureeValue;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.Label labelPeriode;
        private System.Windows.Forms.ListBox listBoxPeriod;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelRembours;
        private System.Windows.Forms.Label labelNbRembours;
        private System.Windows.Forms.Label labelMontant;
        private System.Windows.Forms.ErrorProvider errorProviderLoan;
    }
}

