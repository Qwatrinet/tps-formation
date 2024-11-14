namespace bob
{
    partial class ProdBar
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
            this.components = new System.ComponentModel.Container();
            this.labelProd = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timerProd = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelProd
            // 
            this.labelProd.AutoSize = true;
            this.labelProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProd.Location = new System.Drawing.Point(3, 20);
            this.labelProd.Name = "labelProd";
            this.labelProd.Size = new System.Drawing.Size(112, 20);
            this.labelProd.TabIndex = 0;
            this.labelProd.Text = "Production A";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(175, 20);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(473, 20);
            this.progressBar1.TabIndex = 1;
            // 
            // timerProd
            // 
            this.timerProd.Interval = 10;
            // 
            // ProdBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.labelProd);
            this.Name = "ProdBar";
            this.Size = new System.Drawing.Size(648, 47);
            this.Load += new System.EventHandler(this.ProdBar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelProd;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timerProd;
    }
}
