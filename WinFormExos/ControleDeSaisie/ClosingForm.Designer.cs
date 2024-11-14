namespace ControleDeSaisie
{
    partial class ClosingForm
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
            this.labelFin = new System.Windows.Forms.Label();
            this.buttonOui = new System.Windows.Forms.Button();
            this.buttonNon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelFin
            // 
            this.labelFin.AutoSize = true;
            this.labelFin.Location = new System.Drawing.Point(81, 95);
            this.labelFin.Name = "labelFin";
            this.labelFin.Size = new System.Drawing.Size(94, 13);
            this.labelFin.TabIndex = 0;
            this.labelFin.Text = "Fin de l\'application";
            // 
            // buttonOui
            // 
            this.buttonOui.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.buttonOui.Location = new System.Drawing.Point(38, 166);
            this.buttonOui.Name = "buttonOui";
            this.buttonOui.Size = new System.Drawing.Size(75, 23);
            this.buttonOui.TabIndex = 1;
            this.buttonOui.Text = "Oui";
            this.buttonOui.UseVisualStyleBackColor = true;
            this.buttonOui.Click += new System.EventHandler(this.buttonOui_Click);
            // 
            // buttonNon
            // 
            this.buttonNon.DialogResult = System.Windows.Forms.DialogResult.No;
            this.buttonNon.Location = new System.Drawing.Point(144, 166);
            this.buttonNon.Name = "buttonNon";
            this.buttonNon.Size = new System.Drawing.Size(75, 23);
            this.buttonNon.TabIndex = 2;
            this.buttonNon.Text = "Non";
            this.buttonNon.UseVisualStyleBackColor = true;
            this.buttonNon.Click += new System.EventHandler(this.buttonNon_Click);
            // 
            // ClosingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 229);
            this.Controls.Add(this.buttonNon);
            this.Controls.Add(this.buttonOui);
            this.Controls.Add(this.labelFin);
            this.Name = "ClosingForm";
            this.Text = "ClosingForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFin;
        private System.Windows.Forms.Button buttonOui;
        private System.Windows.Forms.Button buttonNon;
    }
}