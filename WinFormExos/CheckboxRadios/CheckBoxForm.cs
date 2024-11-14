using System;
using System.Drawing;
using System.Windows.Forms;

namespace CheckboxRadios
{
    public partial class CheckBoxForm : Form
    {
        Parametres parametres;
        public CheckBoxForm()
        {
            InitializeComponent();
            labelTexteTranscrit.Text = "";
            labelTexteTranscrit.BackColor = Color.Transparent;
            labelTexteTranscrit.ForeColor = Color.Black;

        }

        public CheckBoxForm(string bob)
        {
            InitializeComponent();
            textBoxBob.Text = bob;
            labelTexteTranscrit.Text = bob;
            labelTexteTranscrit.BackColor = Color.Transparent;
            labelTexteTranscrit.ForeColor = Color.Black;

        }

        private void checkBoxCouleurFond_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox couleurFond = (CheckBox)sender;
            groupBoxFond.Visible = couleurFond.Checked;
            if (!couleurFond.Checked)
            {
                labelTexteTranscrit.BackColor = Color.Transparent;
                radioButtonBleu.Checked = false;
                radioButtonRouge.Checked = false;
                radioButtonVert.Checked = false;
            }
        }
        private void checkBoxCouleurCaracteres_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox couleurCaracteres = (CheckBox)sender;
            groupBoxCaracteres.Visible = couleurCaracteres.Checked;
            if (!couleurCaracteres.Checked)
            {
                labelTexteTranscrit.ForeColor = Color.Black;
                radioButtonCaractereBlanc.Checked = false;
                radioButtonCaractereRouge.Checked = false;
                radioButtonCaractereNoir.Checked = true;
            }
        }

        private void checkBoxCasse_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox casse = (CheckBox)sender;
            groupBoxCasse.Visible = casse.Checked;
            if (!casse.Checked)
            {
                labelTexteTranscrit.Text = textBoxBob.Text;
                radioButtonMajuscules.Checked = false;
                radioButtonMinuscules.Checked = false;
            }
        }

        private void radioButtonRouge_CheckedChanged(object sender, EventArgs e)
        {
            if (!((RadioButton)sender).Checked)
            {
                return;
            }
            labelTexteTranscrit.BackColor = Color.FromName(((RadioButton)sender).Tag.ToString());
        }

        private void radioButtonCaractereRouge_CheckedChanged(object sender, EventArgs e)
        {
            if (!((RadioButton)sender).Checked)
            {
                return;
            }
            labelTexteTranscrit.ForeColor = Color.FromName(((RadioButton)sender).Tag.ToString());
        }

        private void radioButtonMinuscules_CheckedChanged(object sender, EventArgs e)
        {
            if (!((RadioButton)sender).Checked)
            {
                return;
            }
            if (((RadioButton)sender) == radioButtonMinuscules)
            {
                labelTexteTranscrit.Text = textBoxBob.Text.ToLower();
                return;
            }
            labelTexteTranscrit.Text = textBoxBob.Text.ToUpper();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;

            labelTexteTranscrit.Text = this.ApplyTextModifier(textbox.Text);
            if (textbox.Text.Length > 0)
            {
                groupBoxChoix.Enabled = true;
                return;
            }
            checkBoxCasse.Checked = false;
            checkBoxCouleurCaracteres.Checked = false;
            checkBoxCouleurFond.Checked = false;
            groupBoxCaracteres.Visible = false;
            groupBoxCasse.Visible = false;
            groupBoxFond.Visible = false;
            groupBoxChoix.Enabled = false;
        }

        private string ApplyTextModifier(string text)
        {
            if (radioButtonMinuscules.Checked)
            {
                return textBoxBob.Text.ToLower();
            }
            else if (radioButtonMajuscules.Checked)
            {
                return textBoxBob.Text.ToUpper();
            }
            else
            {
                return textBoxBob.Text;
            }
        }
    }
}
