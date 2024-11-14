namespace ListBoxForms
{
    partial class ListBoxForm
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
            this.labelNvElem = new System.Windows.Forms.Label();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.buttonAjoutListe = new System.Windows.Forms.Button();
            this.listBoxNoms = new System.Windows.Forms.ListBox();
            this.labelListe = new System.Windows.Forms.Label();
            this.labelIndexElem = new System.Windows.Forms.Label();
            this.textBoxIndex = new System.Windows.Forms.TextBox();
            this.buttonSelectionner = new System.Windows.Forms.Button();
            this.buttonVider = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCount = new System.Windows.Forms.Label();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.textBoxSelectedIndex = new System.Windows.Forms.TextBox();
            this.labelSelectedIndex = new System.Windows.Forms.Label();
            this.labelTexte = new System.Windows.Forms.Label();
            this.textBoxText = new System.Windows.Forms.TextBox();
            this.errorProviderIndex = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderIndex)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNvElem
            // 
            this.labelNvElem.AutoSize = true;
            this.labelNvElem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNvElem.Location = new System.Drawing.Point(69, 37);
            this.labelNvElem.Name = "labelNvElem";
            this.labelNvElem.Size = new System.Drawing.Size(134, 20);
            this.labelNvElem.TabIndex = 0;
            this.labelNvElem.Text = "Nouvel Elément";
            // 
            // textBoxNom
            // 
            this.textBoxNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNom.Location = new System.Drawing.Point(72, 69);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(131, 26);
            this.textBoxNom.TabIndex = 1;
            // 
            // buttonAjoutListe
            // 
            this.buttonAjoutListe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAjoutListe.Location = new System.Drawing.Point(72, 106);
            this.buttonAjoutListe.Name = "buttonAjoutListe";
            this.buttonAjoutListe.Size = new System.Drawing.Size(131, 31);
            this.buttonAjoutListe.TabIndex = 2;
            this.buttonAjoutListe.Text = "Ajout Liste";
            this.buttonAjoutListe.UseVisualStyleBackColor = true;
            this.buttonAjoutListe.Click += new System.EventHandler(this.buttonAjoutListe_Click);
            // 
            // listBoxNoms
            // 
            this.listBoxNoms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxNoms.FormattingEnabled = true;
            this.listBoxNoms.ItemHeight = 20;
            this.listBoxNoms.Location = new System.Drawing.Point(72, 199);
            this.listBoxNoms.Name = "listBoxNoms";
            this.listBoxNoms.Size = new System.Drawing.Size(131, 144);
            this.listBoxNoms.TabIndex = 3;
            this.listBoxNoms.SelectedIndexChanged += new System.EventHandler(this.listBoxNoms_SelectedIndexChanged);
            // 
            // labelListe
            // 
            this.labelListe.AutoSize = true;
            this.labelListe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListe.Location = new System.Drawing.Point(69, 167);
            this.labelListe.Name = "labelListe";
            this.labelListe.Size = new System.Drawing.Size(48, 20);
            this.labelListe.TabIndex = 4;
            this.labelListe.Text = "Liste";
            // 
            // labelIndexElem
            // 
            this.labelIndexElem.AutoSize = true;
            this.labelIndexElem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIndexElem.Location = new System.Drawing.Point(285, 37);
            this.labelIndexElem.Name = "labelIndexElem";
            this.labelIndexElem.Size = new System.Drawing.Size(124, 20);
            this.labelIndexElem.TabIndex = 5;
            this.labelIndexElem.Text = "Index Elément";
            // 
            // textBoxIndex
            // 
            this.textBoxIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIndex.Location = new System.Drawing.Point(289, 69);
            this.textBoxIndex.Name = "textBoxIndex";
            this.textBoxIndex.Size = new System.Drawing.Size(45, 26);
            this.textBoxIndex.TabIndex = 6;
            // 
            // buttonSelectionner
            // 
            this.buttonSelectionner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelectionner.Location = new System.Drawing.Point(369, 69);
            this.buttonSelectionner.Name = "buttonSelectionner";
            this.buttonSelectionner.Size = new System.Drawing.Size(119, 31);
            this.buttonSelectionner.TabIndex = 7;
            this.buttonSelectionner.Text = "Sélectionner";
            this.buttonSelectionner.UseVisualStyleBackColor = true;
            this.buttonSelectionner.Click += new System.EventHandler(this.buttonSelectionner_Click);
            // 
            // buttonVider
            // 
            this.buttonVider.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVider.Location = new System.Drawing.Point(369, 106);
            this.buttonVider.Name = "buttonVider";
            this.buttonVider.Size = new System.Drawing.Size(119, 31);
            this.buttonVider.TabIndex = 8;
            this.buttonVider.Text = "Vider La Liste";
            this.buttonVider.UseVisualStyleBackColor = true;
            this.buttonVider.Click += new System.EventHandler(this.buttonVider_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(285, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Propriétés";
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCount.Location = new System.Drawing.Point(285, 211);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(96, 20);
            this.labelCount.TabIndex = 10;
            this.labelCount.Text = "Items.Count";
            // 
            // textBoxCount
            // 
            this.textBoxCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCount.Location = new System.Drawing.Point(403, 211);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.ReadOnly = true;
            this.textBoxCount.Size = new System.Drawing.Size(100, 26);
            this.textBoxCount.TabIndex = 11;
            // 
            // textBoxSelectedIndex
            // 
            this.textBoxSelectedIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSelectedIndex.Location = new System.Drawing.Point(403, 266);
            this.textBoxSelectedIndex.Name = "textBoxSelectedIndex";
            this.textBoxSelectedIndex.ReadOnly = true;
            this.textBoxSelectedIndex.Size = new System.Drawing.Size(100, 26);
            this.textBoxSelectedIndex.TabIndex = 12;
            // 
            // labelSelectedIndex
            // 
            this.labelSelectedIndex.AutoSize = true;
            this.labelSelectedIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectedIndex.Location = new System.Drawing.Point(285, 266);
            this.labelSelectedIndex.Name = "labelSelectedIndex";
            this.labelSelectedIndex.Size = new System.Drawing.Size(111, 20);
            this.labelSelectedIndex.TabIndex = 13;
            this.labelSelectedIndex.Text = "SelectedIndex";
            // 
            // labelTexte
            // 
            this.labelTexte.AutoSize = true;
            this.labelTexte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTexte.Location = new System.Drawing.Point(285, 323);
            this.labelTexte.Name = "labelTexte";
            this.labelTexte.Size = new System.Drawing.Size(39, 20);
            this.labelTexte.TabIndex = 14;
            this.labelTexte.Text = "Text";
            // 
            // textBoxText
            // 
            this.textBoxText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxText.Location = new System.Drawing.Point(403, 323);
            this.textBoxText.Name = "textBoxText";
            this.textBoxText.ReadOnly = true;
            this.textBoxText.Size = new System.Drawing.Size(100, 26);
            this.textBoxText.TabIndex = 15;
            // 
            // errorProviderIndex
            // 
            this.errorProviderIndex.ContainerControl = this;
            // 
            // ListBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxText);
            this.Controls.Add(this.labelTexte);
            this.Controls.Add(this.labelSelectedIndex);
            this.Controls.Add(this.textBoxSelectedIndex);
            this.Controls.Add(this.textBoxCount);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonVider);
            this.Controls.Add(this.buttonSelectionner);
            this.Controls.Add(this.textBoxIndex);
            this.Controls.Add(this.labelIndexElem);
            this.Controls.Add(this.labelListe);
            this.Controls.Add(this.listBoxNoms);
            this.Controls.Add(this.buttonAjoutListe);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.labelNvElem);
            this.Name = "ListBoxForm";
            this.Text = "Les listes et leurs propriétés";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderIndex)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNvElem;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.Button buttonAjoutListe;
        private System.Windows.Forms.ListBox listBoxNoms;
        private System.Windows.Forms.Label labelListe;
        private System.Windows.Forms.Label labelIndexElem;
        private System.Windows.Forms.TextBox textBoxIndex;
        private System.Windows.Forms.Button buttonSelectionner;
        private System.Windows.Forms.Button buttonVider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.TextBox textBoxSelectedIndex;
        private System.Windows.Forms.Label labelSelectedIndex;
        private System.Windows.Forms.Label labelTexte;
        private System.Windows.Forms.TextBox textBoxText;
        private System.Windows.Forms.ErrorProvider errorProviderIndex;
    }
}

