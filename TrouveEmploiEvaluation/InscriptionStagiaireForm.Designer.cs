namespace TrouveEmploiEvaluation
{
    partial class InscriptionStagiaireForm
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
            this.titre = new System.Windows.Forms.Label();
            this.labelNom = new System.Windows.Forms.Label();
            this.labelPrenom = new System.Windows.Forms.Label();
            this.labelDebut = new System.Windows.Forms.Label();
            this.labelFin = new System.Windows.Forms.Label();
            this.listBoxFormation = new System.Windows.Forms.ListBox();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.textBoxDateDebut = new System.Windows.Forms.TextBox();
            this.textBoxDateFin = new System.Windows.Forms.TextBox();
            this.labelFormation = new System.Windows.Forms.Label();
            this.errorProviderStagiaire = new System.Windows.Forms.ErrorProvider(this.components);
            this.buttonValider = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderStagiaire)).BeginInit();
            this.SuspendLayout();
            // 
            // titre
            // 
            this.titre.AutoSize = true;
            this.titre.Location = new System.Drawing.Point(310, 35);
            this.titre.Name = "titre";
            this.titre.Size = new System.Drawing.Size(113, 13);
            this.titre.TabIndex = 0;
            this.titre.Text = "Formulaire d\'inscription";
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(165, 119);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(32, 13);
            this.labelNom.TabIndex = 1;
            this.labelNom.Text = "Nom:";
            // 
            // labelPrenom
            // 
            this.labelPrenom.AutoSize = true;
            this.labelPrenom.Location = new System.Drawing.Point(165, 168);
            this.labelPrenom.Name = "labelPrenom";
            this.labelPrenom.Size = new System.Drawing.Size(46, 13);
            this.labelPrenom.TabIndex = 2;
            this.labelPrenom.Text = "Prénom:";
            // 
            // labelDebut
            // 
            this.labelDebut.AutoSize = true;
            this.labelDebut.Location = new System.Drawing.Point(165, 215);
            this.labelDebut.Name = "labelDebut";
            this.labelDebut.Size = new System.Drawing.Size(111, 13);
            this.labelDebut.TabIndex = 3;
            this.labelDebut.Text = "Début de la formation:";
            // 
            // labelFin
            // 
            this.labelFin.AutoSize = true;
            this.labelFin.Location = new System.Drawing.Point(165, 258);
            this.labelFin.Name = "labelFin";
            this.labelFin.Size = new System.Drawing.Size(96, 13);
            this.labelFin.TabIndex = 4;
            this.labelFin.Text = "Fin de la formation:";
            // 
            // listBoxFormation
            // 
            this.listBoxFormation.FormattingEnabled = true;
            this.listBoxFormation.Items.AddRange(new object[] {
            "Choisissez votre formation",
            "CDA",
            "DWWM",
            "ABC-DEV"});
            this.listBoxFormation.Location = new System.Drawing.Point(346, 302);
            this.listBoxFormation.Name = "listBoxFormation";
            this.listBoxFormation.Size = new System.Drawing.Size(174, 95);
            this.listBoxFormation.TabIndex = 5;
            this.listBoxFormation.SelectedIndexChanged += new System.EventHandler(this.listBoxFormation_SelectedIndexChanged);
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(346, 119);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(100, 20);
            this.textBoxNom.TabIndex = 6;
            this.textBoxNom.TextChanged += new System.EventHandler(this.textBoxNom_TextChanged);
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.Location = new System.Drawing.Point(346, 168);
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrenom.TabIndex = 7;
            this.textBoxPrenom.TextChanged += new System.EventHandler(this.textBoxNom_TextChanged);
            // 
            // textBoxDateDebut
            // 
            this.textBoxDateDebut.Location = new System.Drawing.Point(346, 215);
            this.textBoxDateDebut.Name = "textBoxDateDebut";
            this.textBoxDateDebut.Size = new System.Drawing.Size(100, 20);
            this.textBoxDateDebut.TabIndex = 8;
            this.textBoxDateDebut.TextChanged += new System.EventHandler(this.textBoxDateDebut_TextChanged);
            // 
            // textBoxDateFin
            // 
            this.textBoxDateFin.Location = new System.Drawing.Point(346, 258);
            this.textBoxDateFin.Name = "textBoxDateFin";
            this.textBoxDateFin.Size = new System.Drawing.Size(100, 20);
            this.textBoxDateFin.TabIndex = 9;
            this.textBoxDateFin.TextChanged += new System.EventHandler(this.textBoxDateDebut_TextChanged);
            // 
            // labelFormation
            // 
            this.labelFormation.AutoSize = true;
            this.labelFormation.Location = new System.Drawing.Point(165, 302);
            this.labelFormation.Name = "labelFormation";
            this.labelFormation.Size = new System.Drawing.Size(104, 13);
            this.labelFormation.TabIndex = 10;
            this.labelFormation.Text = "Nom de la formation:";
            // 
            // errorProviderStagiaire
            // 
            this.errorProviderStagiaire.ContainerControl = this;
            // 
            // buttonValider
            // 
            this.buttonValider.Location = new System.Drawing.Point(168, 374);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(75, 23);
            this.buttonValider.TabIndex = 11;
            this.buttonValider.Text = "Valider";
            this.buttonValider.UseVisualStyleBackColor = true;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // InscriptionStagiaireForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonValider);
            this.Controls.Add(this.labelFormation);
            this.Controls.Add(this.textBoxDateFin);
            this.Controls.Add(this.textBoxDateDebut);
            this.Controls.Add(this.textBoxPrenom);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.listBoxFormation);
            this.Controls.Add(this.labelFin);
            this.Controls.Add(this.labelDebut);
            this.Controls.Add(this.labelPrenom);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.titre);
            this.Name = "InscriptionStagiaireForm";
            this.Text = "Inscription";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderStagiaire)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titre;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelPrenom;
        private System.Windows.Forms.Label labelDebut;
        private System.Windows.Forms.Label labelFin;
        private System.Windows.Forms.ListBox listBoxFormation;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxPrenom;
        private System.Windows.Forms.TextBox textBoxDateDebut;
        private System.Windows.Forms.TextBox textBoxDateFin;
        private System.Windows.Forms.Label labelFormation;
        private System.Windows.Forms.ErrorProvider errorProviderStagiaire;
        private System.Windows.Forms.Button buttonValider;
    }
}

