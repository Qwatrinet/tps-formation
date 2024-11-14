namespace bob
{
    partial class TabCaisses
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

        #region Code généré par le Concepteur de composants

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelNbCaisses = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelDefautTotal = new System.Windows.Forms.Label();
            this.textBoxDefautTotal = new System.Windows.Forms.TextBox();
            this.textBoxDefautHeure = new System.Windows.Forms.TextBox();
            this.labelDefautHeure = new System.Windows.Forms.Label();
            this.textBoxnbCaisses = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNbCaisses
            // 
            this.labelNbCaisses.AutoSize = true;
            this.labelNbCaisses.Location = new System.Drawing.Point(12, 21);
            this.labelNbCaisses.Name = "labelNbCaisses";
            this.labelNbCaisses.Size = new System.Drawing.Size(195, 13);
            this.labelNbCaisses.TabIndex = 1;
            this.labelNbCaisses.Text = "Nombre de caisses depuis le démarrage";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.labelDefautTotal);
            this.panel1.Controls.Add(this.textBoxDefautTotal);
            this.panel1.Controls.Add(this.textBoxDefautHeure);
            this.panel1.Controls.Add(this.labelDefautHeure);
            this.panel1.Controls.Add(this.textBoxnbCaisses);
            this.panel1.Controls.Add(this.labelNbCaisses);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 142);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Taux défaut depuis démarrage";
            // 
            // labelDefautTotal
            // 
            this.labelDefautTotal.AutoSize = true;
            this.labelDefautTotal.Location = new System.Drawing.Point(12, 145);
            this.labelDefautTotal.Name = "labelDefautTotal";
            this.labelDefautTotal.Size = new System.Drawing.Size(151, 13);
            this.labelDefautTotal.TabIndex = 8;
            this.labelDefautTotal.Text = "Taux défaut depuis démarrage";
            // 
            // textBoxDefautTotal
            // 
            this.textBoxDefautTotal.Location = new System.Drawing.Point(239, 102);
            this.textBoxDefautTotal.Name = "textBoxDefautTotal";
            this.textBoxDefautTotal.Size = new System.Drawing.Size(100, 20);
            this.textBoxDefautTotal.TabIndex = 7;
            // 
            // textBoxDefautHeure
            // 
            this.textBoxDefautHeure.Location = new System.Drawing.Point(239, 63);
            this.textBoxDefautHeure.Name = "textBoxDefautHeure";
            this.textBoxDefautHeure.Size = new System.Drawing.Size(100, 20);
            this.textBoxDefautHeure.TabIndex = 6;
            // 
            // labelDefautHeure
            // 
            this.labelDefautHeure.AutoSize = true;
            this.labelDefautHeure.Location = new System.Drawing.Point(12, 63);
            this.labelDefautHeure.Name = "labelDefautHeure";
            this.labelDefautHeure.Size = new System.Drawing.Size(94, 13);
            this.labelDefautHeure.TabIndex = 5;
            this.labelDefautHeure.Text = "Taux défaut heure";
            // 
            // textBoxnbCaisses
            // 
            this.textBoxnbCaisses.Location = new System.Drawing.Point(239, 21);
            this.textBoxnbCaisses.Name = "textBoxnbCaisses";
            this.textBoxnbCaisses.Size = new System.Drawing.Size(100, 20);
            this.textBoxnbCaisses.TabIndex = 4;
            // 
            // TabCaisses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "TabCaisses";
            this.Size = new System.Drawing.Size(366, 142);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelNbCaisses;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxnbCaisses;
        private System.Windows.Forms.Label labelDefautHeure;
        private System.Windows.Forms.TextBox textBoxDefautHeure;
        private System.Windows.Forms.TextBox textBoxDefautTotal;
        private System.Windows.Forms.Label labelDefautTotal;
        private System.Windows.Forms.Label label1;
    }
}
