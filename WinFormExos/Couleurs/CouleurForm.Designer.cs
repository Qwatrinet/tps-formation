namespace Couleurs
{
    partial class CouleurForm
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
            this.labelRouge = new System.Windows.Forms.Label();
            this.labelVert = new System.Windows.Forms.Label();
            this.labelBleu = new System.Windows.Forms.Label();
            this.hScrollBarRouge = new System.Windows.Forms.HScrollBar();
            this.hScrollBarVert = new System.Windows.Forms.HScrollBar();
            this.hScrollBarBleu = new System.Windows.Forms.HScrollBar();
            this.numericUpDownRouge = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownVert = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownBleu = new System.Windows.Forms.NumericUpDown();
            this.panelRouge = new System.Windows.Forms.Panel();
            this.panelVert = new System.Windows.Forms.Panel();
            this.panelBleu = new System.Windows.Forms.Panel();
            this.panelTotal = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRouge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBleu)).BeginInit();
            this.SuspendLayout();
            // 
            // labelRouge
            // 
            this.labelRouge.AutoSize = true;
            this.labelRouge.Location = new System.Drawing.Point(109, 101);
            this.labelRouge.Name = "labelRouge";
            this.labelRouge.Size = new System.Drawing.Size(39, 13);
            this.labelRouge.TabIndex = 0;
            this.labelRouge.Text = "Rouge";
            // 
            // labelVert
            // 
            this.labelVert.AutoSize = true;
            this.labelVert.Location = new System.Drawing.Point(109, 148);
            this.labelVert.Name = "labelVert";
            this.labelVert.Size = new System.Drawing.Size(26, 13);
            this.labelVert.TabIndex = 1;
            this.labelVert.Text = "Vert";
            // 
            // labelBleu
            // 
            this.labelBleu.AutoSize = true;
            this.labelBleu.Location = new System.Drawing.Point(109, 193);
            this.labelBleu.Name = "labelBleu";
            this.labelBleu.Size = new System.Drawing.Size(28, 13);
            this.labelBleu.TabIndex = 2;
            this.labelBleu.Text = "Bleu";
            // 
            // hScrollBarRouge
            // 
            this.hScrollBarRouge.LargeChange = 1;
            this.hScrollBarRouge.Location = new System.Drawing.Point(165, 101);
            this.hScrollBarRouge.Maximum = 255;
            this.hScrollBarRouge.Name = "hScrollBarRouge";
            this.hScrollBarRouge.Size = new System.Drawing.Size(212, 21);
            this.hScrollBarRouge.TabIndex = 3;
            this.hScrollBarRouge.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarRouge_Scroll);
            // 
            // hScrollBarVert
            // 
            this.hScrollBarVert.LargeChange = 1;
            this.hScrollBarVert.Location = new System.Drawing.Point(165, 148);
            this.hScrollBarVert.Maximum = 255;
            this.hScrollBarVert.Name = "hScrollBarVert";
            this.hScrollBarVert.Size = new System.Drawing.Size(212, 21);
            this.hScrollBarVert.TabIndex = 4;
            this.hScrollBarVert.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarVert_Scroll);
            // 
            // hScrollBarBleu
            // 
            this.hScrollBarBleu.LargeChange = 1;
            this.hScrollBarBleu.Location = new System.Drawing.Point(165, 193);
            this.hScrollBarBleu.Maximum = 255;
            this.hScrollBarBleu.Name = "hScrollBarBleu";
            this.hScrollBarBleu.Size = new System.Drawing.Size(212, 21);
            this.hScrollBarBleu.TabIndex = 5;
            this.hScrollBarBleu.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarBleu_Scroll);
            // 
            // numericUpDownRouge
            // 
            this.numericUpDownRouge.Location = new System.Drawing.Point(398, 102);
            this.numericUpDownRouge.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownRouge.Name = "numericUpDownRouge";
            this.numericUpDownRouge.Size = new System.Drawing.Size(60, 20);
            this.numericUpDownRouge.TabIndex = 6;
            this.numericUpDownRouge.ValueChanged += new System.EventHandler(this.numericUpDownRouge_ValueChanged);
            // 
            // numericUpDownVert
            // 
            this.numericUpDownVert.Location = new System.Drawing.Point(398, 149);
            this.numericUpDownVert.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownVert.Name = "numericUpDownVert";
            this.numericUpDownVert.Size = new System.Drawing.Size(60, 20);
            this.numericUpDownVert.TabIndex = 7;
            this.numericUpDownVert.ValueChanged += new System.EventHandler(this.numericUpDownVert_ValueChanged);
            // 
            // numericUpDownBleu
            // 
            this.numericUpDownBleu.Location = new System.Drawing.Point(398, 194);
            this.numericUpDownBleu.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownBleu.Name = "numericUpDownBleu";
            this.numericUpDownBleu.Size = new System.Drawing.Size(60, 20);
            this.numericUpDownBleu.TabIndex = 8;
            this.numericUpDownBleu.ValueChanged += new System.EventHandler(this.numericUpDownBleu_ValueChanged);
            // 
            // panelRouge
            // 
            this.panelRouge.Location = new System.Drawing.Point(486, 101);
            this.panelRouge.Name = "panelRouge";
            this.panelRouge.Size = new System.Drawing.Size(70, 21);
            this.panelRouge.TabIndex = 10;
            // 
            // panelVert
            // 
            this.panelVert.Location = new System.Drawing.Point(486, 149);
            this.panelVert.Name = "panelVert";
            this.panelVert.Size = new System.Drawing.Size(70, 20);
            this.panelVert.TabIndex = 11;
            // 
            // panelBleu
            // 
            this.panelBleu.Location = new System.Drawing.Point(486, 194);
            this.panelBleu.Name = "panelBleu";
            this.panelBleu.Size = new System.Drawing.Size(70, 20);
            this.panelBleu.TabIndex = 11;
            // 
            // panelTotal
            // 
            this.panelTotal.Location = new System.Drawing.Point(112, 273);
            this.panelTotal.Name = "panelTotal";
            this.panelTotal.Size = new System.Drawing.Size(443, 95);
            this.panelTotal.TabIndex = 12;
            this.panelTotal.Click += new System.EventHandler(this.panelTotal_Click);
            // 
            // CouleurForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelTotal);
            this.Controls.Add(this.panelBleu);
            this.Controls.Add(this.panelVert);
            this.Controls.Add(this.panelRouge);
            this.Controls.Add(this.numericUpDownBleu);
            this.Controls.Add(this.numericUpDownVert);
            this.Controls.Add(this.numericUpDownRouge);
            this.Controls.Add(this.hScrollBarBleu);
            this.Controls.Add(this.hScrollBarVert);
            this.Controls.Add(this.hScrollBarRouge);
            this.Controls.Add(this.labelBleu);
            this.Controls.Add(this.labelVert);
            this.Controls.Add(this.labelRouge);
            this.Name = "CouleurForm";
            this.Text = "Défilement";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRouge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBleu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRouge;
        private System.Windows.Forms.Label labelVert;
        private System.Windows.Forms.Label labelBleu;
        private System.Windows.Forms.HScrollBar hScrollBarRouge;
        private System.Windows.Forms.HScrollBar hScrollBarVert;
        private System.Windows.Forms.HScrollBar hScrollBarBleu;
        private System.Windows.Forms.NumericUpDown numericUpDownRouge;
        private System.Windows.Forms.NumericUpDown numericUpDownVert;
        private System.Windows.Forms.NumericUpDown numericUpDownBleu;
        private System.Windows.Forms.Panel panelRouge;
        private System.Windows.Forms.Panel panelVert;
        private System.Windows.Forms.Panel panelBleu;
        private System.Windows.Forms.Panel panelTotal;
    }
}

