namespace ControleDeSaisie
{
    partial class Validation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Nom = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Code = new System.Windows.Forms.Label();
            this.EcrireNom = new System.Windows.Forms.Label();
            this.EcrireDate = new System.Windows.Forms.Label();
            this.EcrireMontant = new System.Windows.Forms.Label();
            this.EcrireCode = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Nom
            // 
            this.Nom.AutoSize = true;
            this.Nom.Location = new System.Drawing.Point(71, 61);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(35, 13);
            this.Nom.TabIndex = 0;
            this.Nom.Text = "Nom: ";
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Location = new System.Drawing.Point(71, 84);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(36, 13);
            this.Date.TabIndex = 1;
            this.Date.Text = "Date: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Montant:";
            // 
            // Code
            // 
            this.Code.AutoSize = true;
            this.Code.Location = new System.Drawing.Point(71, 135);
            this.Code.Name = "Code";
            this.Code.Size = new System.Drawing.Size(38, 13);
            this.Code.TabIndex = 3;
            this.Code.Text = "Code: ";
            // 
            // EcrireNom
            // 
            this.EcrireNom.AutoSize = true;
            this.EcrireNom.Location = new System.Drawing.Point(125, 65);
            this.EcrireNom.Name = "EcrireNom";
            this.EcrireNom.Size = new System.Drawing.Size(35, 13);
            this.EcrireNom.TabIndex = 4;
            this.EcrireNom.Text = "label2";
            // 
            // EcrireDate
            // 
            this.EcrireDate.AutoSize = true;
            this.EcrireDate.Location = new System.Drawing.Point(125, 84);
            this.EcrireDate.Name = "EcrireDate";
            this.EcrireDate.Size = new System.Drawing.Size(35, 13);
            this.EcrireDate.TabIndex = 5;
            this.EcrireDate.Text = "label3";
            // 
            // EcrireMontant
            // 
            this.EcrireMontant.AutoSize = true;
            this.EcrireMontant.Location = new System.Drawing.Point(125, 110);
            this.EcrireMontant.Name = "EcrireMontant";
            this.EcrireMontant.Size = new System.Drawing.Size(35, 13);
            this.EcrireMontant.TabIndex = 6;
            this.EcrireMontant.Text = "label4";
            // 
            // EcrireCode
            // 
            this.EcrireCode.AutoSize = true;
            this.EcrireCode.Location = new System.Drawing.Point(125, 135);
            this.EcrireCode.Name = "EcrireCode";
            this.EcrireCode.Size = new System.Drawing.Size(35, 13);
            this.EcrireCode.TabIndex = 7;
            this.EcrireCode.Text = "label5";
            // 
            // buttonOk
            // 
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk.Location = new System.Drawing.Point(128, 172);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 8;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // Validation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 207);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.EcrireCode);
            this.Controls.Add(this.EcrireMontant);
            this.Controls.Add(this.EcrireDate);
            this.Controls.Add(this.EcrireNom);
            this.Controls.Add(this.Code);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.Nom);
            this.Name = "Validation";
            this.Text = "Validation effectuée";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nom;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Code;
        private System.Windows.Forms.Label EcrireNom;
        private System.Windows.Forms.Label EcrireDate;
        private System.Windows.Forms.Label EcrireMontant;
        private System.Windows.Forms.Label EcrireCode;
        private System.Windows.Forms.Button buttonOk;
    }
}