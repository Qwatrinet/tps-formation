using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBoxForms
{
    public partial class ListBoxForm : Form
    {
        int count=0;
        public ListBoxForm() { 
            InitializeComponent();
        }

        private void buttonVider_Click(object sender, EventArgs e)
        {
            listBoxNoms.Items.Clear();
            textBoxIndex.Clear();
            textBoxNom.Clear();
            textBoxSelectedIndex.Clear();
            textBoxCount.Clear();
            textBoxText.Clear();
        }

        private void buttonAjoutListe_Click(object sender, EventArgs e)
        {
            if (listBoxNoms.Items.Contains(textBoxNom.Text) || textBoxNom.Text.Length==0)
            {
                return;
            }
            listBoxNoms.Items.Add(textBoxNom.Text);
            textBoxNom.Clear();
            count++;
        }

        private void buttonSelectionner_Click(object sender, EventArgs e)
        {
            if(!int.TryParse(textBoxIndex.Text,out int result))
            {
                this.errorProviderIndex.SetError(textBoxIndex, "L'index doit être un nombre.");
                return;
            }
            if(result >= listBoxNoms.Items.Count || result<0)
            {
                this.errorProviderIndex.SetError(textBoxIndex, "L'index doit être entre 0 et le nombre d'objets dans la liste-1");
                return;
            }
            textBoxCount.Text = count.ToString();
            textBoxSelectedIndex.Text = result.ToString();
            textBoxText.Text = listBoxNoms.Items[result].ToString();
            listBoxNoms.SelectedIndex = result;
        }

        private void listBoxNoms_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index=listBoxNoms.SelectedIndex;
            textBoxSelectedIndex.Text=index.ToString();
            textBoxCount.Text= count.ToString();
            textBoxText.Text= listBoxNoms.Items[index].ToString();
        }
    }
}
