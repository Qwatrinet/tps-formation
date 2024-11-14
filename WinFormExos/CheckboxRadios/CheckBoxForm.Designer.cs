namespace CheckboxRadios
{
    partial class CheckBoxForm
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
            this.labelTaper = new System.Windows.Forms.Label();
            this.textBoxBob = new System.Windows.Forms.TextBox();
            this.checkBoxCouleurFond = new System.Windows.Forms.CheckBox();
            this.checkBoxCouleurCaracteres = new System.Windows.Forms.CheckBox();
            this.checkBoxCasse = new System.Windows.Forms.CheckBox();
            this.groupBoxChoix = new System.Windows.Forms.GroupBox();
            this.groupBoxFond = new System.Windows.Forms.GroupBox();
            this.radioButtonBleu = new System.Windows.Forms.RadioButton();
            this.radioButtonVert = new System.Windows.Forms.RadioButton();
            this.radioButtonRouge = new System.Windows.Forms.RadioButton();
            this.groupBoxCaracteres = new System.Windows.Forms.GroupBox();
            this.radioButtonCaractereNoir = new System.Windows.Forms.RadioButton();
            this.radioButtonCaractereBlanc = new System.Windows.Forms.RadioButton();
            this.radioButtonCaractereRouge = new System.Windows.Forms.RadioButton();
            this.groupBoxCasse = new System.Windows.Forms.GroupBox();
            this.radioButtonMajuscules = new System.Windows.Forms.RadioButton();
            this.radioButtonMinuscules = new System.Windows.Forms.RadioButton();
            this.labelTexteTranscrit = new System.Windows.Forms.Label();
            this.groupBoxChoix.SuspendLayout();
            this.groupBoxFond.SuspendLayout();
            this.groupBoxCaracteres.SuspendLayout();
            this.groupBoxCasse.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTaper
            // 
            this.labelTaper.AutoSize = true;
            this.labelTaper.Location = new System.Drawing.Point(50, 52);
            this.labelTaper.Name = "labelTaper";
            this.labelTaper.Size = new System.Drawing.Size(107, 13);
            this.labelTaper.TabIndex = 0;
            this.labelTaper.Text = "Tapez votre texte nul";
            // 
            // textBoxBob
            // 
            this.textBoxBob.Location = new System.Drawing.Point(53, 101);
            this.textBoxBob.Multiline = true;
            this.textBoxBob.Name = "textBoxBob";
            this.textBoxBob.Size = new System.Drawing.Size(248, 42);
            this.textBoxBob.TabIndex = 1;
            this.textBoxBob.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // checkBoxCouleurFond
            // 
            this.checkBoxCouleurFond.AutoSize = true;
            this.checkBoxCouleurFond.Location = new System.Drawing.Point(18, 28);
            this.checkBoxCouleurFond.Name = "checkBoxCouleurFond";
            this.checkBoxCouleurFond.Size = new System.Drawing.Size(104, 17);
            this.checkBoxCouleurFond.TabIndex = 2;
            this.checkBoxCouleurFond.Text = "Couleur du Fond";
            this.checkBoxCouleurFond.UseVisualStyleBackColor = true;
            this.checkBoxCouleurFond.CheckedChanged += new System.EventHandler(this.checkBoxCouleurFond_CheckedChanged);
            // 
            // checkBoxCouleurCaracteres
            // 
            this.checkBoxCouleurCaracteres.AutoSize = true;
            this.checkBoxCouleurCaracteres.Location = new System.Drawing.Point(18, 51);
            this.checkBoxCouleurCaracteres.Name = "checkBoxCouleurCaracteres";
            this.checkBoxCouleurCaracteres.Size = new System.Drawing.Size(135, 17);
            this.checkBoxCouleurCaracteres.TabIndex = 4;
            this.checkBoxCouleurCaracteres.Text = "Couleur des caractères";
            this.checkBoxCouleurCaracteres.UseVisualStyleBackColor = true;
            this.checkBoxCouleurCaracteres.CheckedChanged += new System.EventHandler(this.checkBoxCouleurCaracteres_CheckedChanged);
            // 
            // checkBoxCasse
            // 
            this.checkBoxCasse.AutoSize = true;
            this.checkBoxCasse.Location = new System.Drawing.Point(18, 74);
            this.checkBoxCasse.Name = "checkBoxCasse";
            this.checkBoxCasse.Size = new System.Drawing.Size(55, 17);
            this.checkBoxCasse.TabIndex = 5;
            this.checkBoxCasse.Text = "Casse";
            this.checkBoxCasse.UseVisualStyleBackColor = true;
            this.checkBoxCasse.CheckedChanged += new System.EventHandler(this.checkBoxCasse_CheckedChanged);
            // 
            // groupBoxChoix
            // 
            this.groupBoxChoix.Controls.Add(this.checkBoxCouleurFond);
            this.groupBoxChoix.Controls.Add(this.checkBoxCasse);
            this.groupBoxChoix.Controls.Add(this.checkBoxCouleurCaracteres);
            this.groupBoxChoix.Enabled = false;
            this.groupBoxChoix.Location = new System.Drawing.Point(328, 52);
            this.groupBoxChoix.Name = "groupBoxChoix";
            this.groupBoxChoix.Size = new System.Drawing.Size(184, 112);
            this.groupBoxChoix.TabIndex = 6;
            this.groupBoxChoix.TabStop = false;
            this.groupBoxChoix.Text = "Choix";
            // 
            // groupBoxFond
            // 
            this.groupBoxFond.Controls.Add(this.radioButtonBleu);
            this.groupBoxFond.Controls.Add(this.radioButtonVert);
            this.groupBoxFond.Controls.Add(this.radioButtonRouge);
            this.groupBoxFond.Location = new System.Drawing.Point(53, 268);
            this.groupBoxFond.Name = "groupBoxFond";
            this.groupBoxFond.Size = new System.Drawing.Size(114, 136);
            this.groupBoxFond.TabIndex = 7;
            this.groupBoxFond.TabStop = false;
            this.groupBoxFond.Text = "Fond";
            this.groupBoxFond.Visible = false;
            // 
            // radioButtonBleu
            // 
            this.radioButtonBleu.AutoSize = true;
            this.radioButtonBleu.Location = new System.Drawing.Point(15, 97);
            this.radioButtonBleu.Name = "radioButtonBleu";
            this.radioButtonBleu.Size = new System.Drawing.Size(46, 17);
            this.radioButtonBleu.TabIndex = 2;
            this.radioButtonBleu.TabStop = true;
            this.radioButtonBleu.Tag = "Blue";
            this.radioButtonBleu.Text = "Bleu";
            this.radioButtonBleu.UseVisualStyleBackColor = true;
            this.radioButtonBleu.CheckedChanged += new System.EventHandler(this.radioButtonRouge_CheckedChanged);
            // 
            // radioButtonVert
            // 
            this.radioButtonVert.AutoSize = true;
            this.radioButtonVert.Location = new System.Drawing.Point(15, 59);
            this.radioButtonVert.Name = "radioButtonVert";
            this.radioButtonVert.Size = new System.Drawing.Size(44, 17);
            this.radioButtonVert.TabIndex = 1;
            this.radioButtonVert.TabStop = true;
            this.radioButtonVert.Tag = "Green";
            this.radioButtonVert.Text = "Vert";
            this.radioButtonVert.UseVisualStyleBackColor = true;
            this.radioButtonVert.CheckedChanged += new System.EventHandler(this.radioButtonRouge_CheckedChanged);
            // 
            // radioButtonRouge
            // 
            this.radioButtonRouge.AutoSize = true;
            this.radioButtonRouge.Location = new System.Drawing.Point(15, 19);
            this.radioButtonRouge.Name = "radioButtonRouge";
            this.radioButtonRouge.Size = new System.Drawing.Size(57, 17);
            this.radioButtonRouge.TabIndex = 0;
            this.radioButtonRouge.TabStop = true;
            this.radioButtonRouge.Tag = "Red";
            this.radioButtonRouge.Text = "Rouge";
            this.radioButtonRouge.UseVisualStyleBackColor = true;
            this.radioButtonRouge.CheckedChanged += new System.EventHandler(this.radioButtonRouge_CheckedChanged);
            // 
            // groupBoxCaracteres
            // 
            this.groupBoxCaracteres.Controls.Add(this.radioButtonCaractereNoir);
            this.groupBoxCaracteres.Controls.Add(this.radioButtonCaractereBlanc);
            this.groupBoxCaracteres.Controls.Add(this.radioButtonCaractereRouge);
            this.groupBoxCaracteres.Location = new System.Drawing.Point(192, 268);
            this.groupBoxCaracteres.Name = "groupBoxCaracteres";
            this.groupBoxCaracteres.Size = new System.Drawing.Size(109, 134);
            this.groupBoxCaracteres.TabIndex = 8;
            this.groupBoxCaracteres.TabStop = false;
            this.groupBoxCaracteres.Text = "Caractères";
            this.groupBoxCaracteres.Visible = false;
            // 
            // radioButtonCaractereNoir
            // 
            this.radioButtonCaractereNoir.AutoSize = true;
            this.radioButtonCaractereNoir.Checked = true;
            this.radioButtonCaractereNoir.Location = new System.Drawing.Point(12, 97);
            this.radioButtonCaractereNoir.Name = "radioButtonCaractereNoir";
            this.radioButtonCaractereNoir.Size = new System.Drawing.Size(44, 17);
            this.radioButtonCaractereNoir.TabIndex = 3;
            this.radioButtonCaractereNoir.TabStop = true;
            this.radioButtonCaractereNoir.Tag = "Black";
            this.radioButtonCaractereNoir.Text = "Noir";
            this.radioButtonCaractereNoir.UseVisualStyleBackColor = true;
            // 
            // radioButtonCaractereBlanc
            // 
            this.radioButtonCaractereBlanc.AutoSize = true;
            this.radioButtonCaractereBlanc.Location = new System.Drawing.Point(12, 59);
            this.radioButtonCaractereBlanc.Name = "radioButtonCaractereBlanc";
            this.radioButtonCaractereBlanc.Size = new System.Drawing.Size(52, 17);
            this.radioButtonCaractereBlanc.TabIndex = 2;
            this.radioButtonCaractereBlanc.Tag = "White";
            this.radioButtonCaractereBlanc.Text = "Blanc";
            this.radioButtonCaractereBlanc.UseVisualStyleBackColor = true;
            this.radioButtonCaractereBlanc.CheckedChanged += new System.EventHandler(this.radioButtonCaractereRouge_CheckedChanged);
            // 
            // radioButtonCaractereRouge
            // 
            this.radioButtonCaractereRouge.AutoSize = true;
            this.radioButtonCaractereRouge.Location = new System.Drawing.Point(12, 19);
            this.radioButtonCaractereRouge.Name = "radioButtonCaractereRouge";
            this.radioButtonCaractereRouge.Size = new System.Drawing.Size(57, 17);
            this.radioButtonCaractereRouge.TabIndex = 1;
            this.radioButtonCaractereRouge.Tag = "Red";
            this.radioButtonCaractereRouge.Text = "Rouge";
            this.radioButtonCaractereRouge.UseVisualStyleBackColor = true;
            this.radioButtonCaractereRouge.CheckedChanged += new System.EventHandler(this.radioButtonCaractereRouge_CheckedChanged);
            // 
            // groupBoxCasse
            // 
            this.groupBoxCasse.Controls.Add(this.radioButtonMajuscules);
            this.groupBoxCasse.Controls.Add(this.radioButtonMinuscules);
            this.groupBoxCasse.Location = new System.Drawing.Point(328, 287);
            this.groupBoxCasse.Name = "groupBoxCasse";
            this.groupBoxCasse.Size = new System.Drawing.Size(98, 115);
            this.groupBoxCasse.TabIndex = 9;
            this.groupBoxCasse.TabStop = false;
            this.groupBoxCasse.Text = "Casse";
            this.groupBoxCasse.Visible = false;
            // 
            // radioButtonMajuscules
            // 
            this.radioButtonMajuscules.AutoSize = true;
            this.radioButtonMajuscules.Location = new System.Drawing.Point(7, 78);
            this.radioButtonMajuscules.Name = "radioButtonMajuscules";
            this.radioButtonMajuscules.Size = new System.Drawing.Size(78, 17);
            this.radioButtonMajuscules.TabIndex = 2;
            this.radioButtonMajuscules.TabStop = true;
            this.radioButtonMajuscules.Text = "Majuscules";
            this.radioButtonMajuscules.UseVisualStyleBackColor = true;
            this.radioButtonMajuscules.CheckedChanged += new System.EventHandler(this.radioButtonMinuscules_CheckedChanged);
            // 
            // radioButtonMinuscules
            // 
            this.radioButtonMinuscules.AutoSize = true;
            this.radioButtonMinuscules.Location = new System.Drawing.Point(6, 40);
            this.radioButtonMinuscules.Name = "radioButtonMinuscules";
            this.radioButtonMinuscules.Size = new System.Drawing.Size(78, 17);
            this.radioButtonMinuscules.TabIndex = 1;
            this.radioButtonMinuscules.TabStop = true;
            this.radioButtonMinuscules.Text = "Minuscules";
            this.radioButtonMinuscules.UseVisualStyleBackColor = true;
            this.radioButtonMinuscules.CheckedChanged += new System.EventHandler(this.radioButtonMinuscules_CheckedChanged);
            // 
            // labelTexteTranscrit
            // 
            this.labelTexteTranscrit.AutoSize = true;
            this.labelTexteTranscrit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTexteTranscrit.Location = new System.Drawing.Point(47, 188);
            this.labelTexteTranscrit.Name = "labelTexteTranscrit";
            this.labelTexteTranscrit.Size = new System.Drawing.Size(212, 31);
            this.labelTexteTranscrit.TabIndex = 11;
            this.labelTexteTranscrit.Text = "Ici s\'écrit l\'avenir";
            // 
            // CheckBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 450);
            this.Controls.Add(this.labelTexteTranscrit);
            this.Controls.Add(this.groupBoxCasse);
            this.Controls.Add(this.groupBoxCaracteres);
            this.Controls.Add(this.groupBoxFond);
            this.Controls.Add(this.groupBoxChoix);
            this.Controls.Add(this.textBoxBob);
            this.Controls.Add(this.labelTaper);
            this.Name = "CheckBox";
            this.Text = "CheckBox et RadioButton";
            this.groupBoxChoix.ResumeLayout(false);
            this.groupBoxChoix.PerformLayout();
            this.groupBoxFond.ResumeLayout(false);
            this.groupBoxFond.PerformLayout();
            this.groupBoxCaracteres.ResumeLayout(false);
            this.groupBoxCaracteres.PerformLayout();
            this.groupBoxCasse.ResumeLayout(false);
            this.groupBoxCasse.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTaper;
        private System.Windows.Forms.TextBox textBoxBob;
        private System.Windows.Forms.CheckBox checkBoxCouleurFond;
        private System.Windows.Forms.CheckBox checkBoxCouleurCaracteres;
        private System.Windows.Forms.CheckBox checkBoxCasse;
        private System.Windows.Forms.GroupBox groupBoxChoix;
        private System.Windows.Forms.GroupBox groupBoxFond;
        private System.Windows.Forms.GroupBox groupBoxCaracteres;
        private System.Windows.Forms.GroupBox groupBoxCasse;
        private System.Windows.Forms.RadioButton radioButtonBleu;
        private System.Windows.Forms.RadioButton radioButtonVert;
        private System.Windows.Forms.RadioButton radioButtonRouge;
        private System.Windows.Forms.RadioButton radioButtonCaractereNoir;
        private System.Windows.Forms.RadioButton radioButtonCaractereBlanc;
        private System.Windows.Forms.RadioButton radioButtonCaractereRouge;
        private System.Windows.Forms.RadioButton radioButtonMajuscules;
        private System.Windows.Forms.RadioButton radioButtonMinuscules;
        private System.Windows.Forms.Label labelTexteTranscrit;
    }
}

