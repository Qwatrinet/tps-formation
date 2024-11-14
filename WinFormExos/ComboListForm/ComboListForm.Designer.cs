namespace ComboListSpace
{
    partial class ComboListForm
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
            this.comboBoxNoms = new System.Windows.Forms.ComboBox();
            this.labelSource = new System.Windows.Forms.Label();
            this.listBoxCible = new System.Windows.Forms.ListBox();
            this.buttonSup = new System.Windows.Forms.Button();
            this.buttonTresSup = new System.Windows.Forms.Button();
            this.buttonInf = new System.Windows.Forms.Button();
            this.buttonTresInf = new System.Windows.Forms.Button();
            this.labelCible = new System.Windows.Forms.Label();
            this.buttonHaut = new System.Windows.Forms.Button();
            this.buttonBas = new System.Windows.Forms.Button();
            this.errorProviderName = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxNoms
            // 
            this.comboBoxNoms.FormattingEnabled = true;
            this.comboBoxNoms.Items.AddRange(new object[] {
            "France",
            "Belgique",
            "Allemagne",
            "Jaaaapon",
            "Portugal",
            "Grèce",
            "Bulgarie",
            "Espagne"});
            this.comboBoxNoms.Location = new System.Drawing.Point(98, 105);
            this.comboBoxNoms.Name = "comboBoxNoms";
            this.comboBoxNoms.Size = new System.Drawing.Size(121, 21);
            this.comboBoxNoms.TabIndex = 0;
            this.comboBoxNoms.SelectedIndexChanged += new System.EventHandler(this.comboBoxNoms_SelectedIndexChanged);
            this.comboBoxNoms.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox1_KeyDown);
            // 
            // labelSource
            // 
            this.labelSource.AutoSize = true;
            this.labelSource.Location = new System.Drawing.Point(95, 79);
            this.labelSource.Name = "labelSource";
            this.labelSource.Size = new System.Drawing.Size(41, 13);
            this.labelSource.TabIndex = 1;
            this.labelSource.Text = "Source";
            // 
            // listBoxCible
            // 
            this.listBoxCible.FormattingEnabled = true;
            this.listBoxCible.Location = new System.Drawing.Point(350, 105);
            this.listBoxCible.Name = "listBoxCible";
            this.listBoxCible.Size = new System.Drawing.Size(120, 160);
            this.listBoxCible.TabIndex = 2;
            this.listBoxCible.SelectedIndexChanged += new System.EventHandler(this.listBoxCible_SelectedIndexChanged);
            // 
            // buttonSup
            // 
            this.buttonSup.Enabled = false;
            this.buttonSup.Location = new System.Drawing.Point(248, 105);
            this.buttonSup.Name = "buttonSup";
            this.buttonSup.Size = new System.Drawing.Size(75, 23);
            this.buttonSup.TabIndex = 3;
            this.buttonSup.Text = ">";
            this.buttonSup.UseVisualStyleBackColor = true;
            this.buttonSup.Click += new System.EventHandler(this.buttonSup_Click);
            // 
            // buttonTresSup
            // 
            this.buttonTresSup.Location = new System.Drawing.Point(248, 144);
            this.buttonTresSup.Name = "buttonTresSup";
            this.buttonTresSup.Size = new System.Drawing.Size(75, 23);
            this.buttonTresSup.TabIndex = 4;
            this.buttonTresSup.Text = ">>";
            this.buttonTresSup.UseVisualStyleBackColor = true;
            this.buttonTresSup.Click += new System.EventHandler(this.buttonTresSup_Click);
            // 
            // buttonInf
            // 
            this.buttonInf.Enabled = false;
            this.buttonInf.Location = new System.Drawing.Point(248, 203);
            this.buttonInf.Name = "buttonInf";
            this.buttonInf.Size = new System.Drawing.Size(75, 23);
            this.buttonInf.TabIndex = 5;
            this.buttonInf.Text = "<";
            this.buttonInf.UseVisualStyleBackColor = true;
            this.buttonInf.Click += new System.EventHandler(this.buttonInf_Click);
            // 
            // buttonTresInf
            // 
            this.buttonTresInf.Enabled = false;
            this.buttonTresInf.Location = new System.Drawing.Point(248, 242);
            this.buttonTresInf.Name = "buttonTresInf";
            this.buttonTresInf.Size = new System.Drawing.Size(75, 23);
            this.buttonTresInf.TabIndex = 6;
            this.buttonTresInf.Text = "<<";
            this.buttonTresInf.UseVisualStyleBackColor = true;
            this.buttonTresInf.Click += new System.EventHandler(this.buttonTresInf_Click);
            // 
            // labelCible
            // 
            this.labelCible.AutoSize = true;
            this.labelCible.Location = new System.Drawing.Point(347, 79);
            this.labelCible.Name = "labelCible";
            this.labelCible.Size = new System.Drawing.Size(30, 13);
            this.labelCible.TabIndex = 7;
            this.labelCible.Text = "Cible";
            // 
            // buttonHaut
            // 
            this.buttonHaut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHaut.Location = new System.Drawing.Point(350, 282);
            this.buttonHaut.Name = "buttonHaut";
            this.buttonHaut.Size = new System.Drawing.Size(50, 36);
            this.buttonHaut.TabIndex = 8;
            this.buttonHaut.Text = "↑";
            this.buttonHaut.UseVisualStyleBackColor = true;
            this.buttonHaut.Click += new System.EventHandler(this.buttonHaut_Click);
            // 
            // buttonBas
            // 
            this.buttonBas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBas.Location = new System.Drawing.Point(420, 282);
            this.buttonBas.Name = "buttonBas";
            this.buttonBas.Size = new System.Drawing.Size(50, 36);
            this.buttonBas.TabIndex = 9;
            this.buttonBas.Text = "↓";
            this.buttonBas.UseVisualStyleBackColor = true;
            this.buttonBas.Click += new System.EventHandler(this.buttonBas_Click);
            // 
            // errorProviderName
            // 
            this.errorProviderName.ContainerControl = this;
            // 
            // ComboListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonBas);
            this.Controls.Add(this.buttonHaut);
            this.Controls.Add(this.labelCible);
            this.Controls.Add(this.buttonTresInf);
            this.Controls.Add(this.buttonInf);
            this.Controls.Add(this.buttonTresSup);
            this.Controls.Add(this.buttonSup);
            this.Controls.Add(this.listBoxCible);
            this.Controls.Add(this.labelSource);
            this.Controls.Add(this.comboBoxNoms);
            this.Name = "ComboListForm";
            this.Text = "Les listes";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxNoms;
        private System.Windows.Forms.Label labelSource;
        private System.Windows.Forms.ListBox listBoxCible;
        private System.Windows.Forms.Button buttonSup;
        private System.Windows.Forms.Button buttonTresSup;
        private System.Windows.Forms.Button buttonInf;
        private System.Windows.Forms.Button buttonTresInf;
        private System.Windows.Forms.Label labelCible;
        private System.Windows.Forms.Button buttonHaut;
        private System.Windows.Forms.Button buttonBas;
        private System.Windows.Forms.ErrorProvider errorProviderName;
    }
}

