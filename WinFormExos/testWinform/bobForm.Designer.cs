namespace testWinform
{
    partial class bobForm
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
            this.question = new System.Windows.Forms.Label();
            this.oui = new System.Windows.Forms.Button();
            this.Non = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // question
            // 
            this.question.AutoSize = true;
            this.question.Location = new System.Drawing.Point(300, 125);
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(65, 13);
            this.question.TabIndex = 0;
            this.question.Text = "tu vas bien?";
            this.question.Click += new System.EventHandler(this.label1_Click);
            // 
            // oui
            // 
            this.oui.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.oui.Location = new System.Drawing.Point(246, 214);
            this.oui.Name = "oui";
            this.oui.Size = new System.Drawing.Size(75, 23);
            this.oui.TabIndex = 1;
            this.oui.Text = "oui";
            this.oui.UseVisualStyleBackColor = true;
            // 
            // Non
            // 
            this.Non.DialogResult = System.Windows.Forms.DialogResult.No;
            this.Non.Location = new System.Drawing.Point(398, 214);
            this.Non.Name = "Non";
            this.Non.Size = new System.Drawing.Size(75, 23);
            this.Non.TabIndex = 2;
            this.Non.Text = "non";
            this.Non.UseVisualStyleBackColor = true;
            // 
            // bobForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Non);
            this.Controls.Add(this.oui);
            this.Controls.Add(this.question);
            this.Name = "bobForm";
            this.Text = "bobForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label question;
        private System.Windows.Forms.Button oui;
        private System.Windows.Forms.Button Non;
    }
}