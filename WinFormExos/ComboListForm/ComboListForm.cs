using System;
using System.Windows.Forms;
using UtilsForms;

namespace ComboListSpace
{
    public partial class ComboListForm : Form
    {
        public ComboListForm()
        {
            InitializeComponent();
            checkButtonEnabled();
        }


        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (comboBoxNoms.Text.Length == 0)
                {
                    return;
                }
                if (comboBoxNoms.Items.Contains(comboBoxNoms.Text))
                {
                    this.errorProviderName.SetError(comboBoxNoms, "Cet élément est déja dans la Source");
                    return;
                }
                if (listBoxCible.Items.Contains(comboBoxNoms.Text))
                {
                    this.errorProviderName.SetError(comboBoxNoms, "Cet élément est déja dans la Cible");
                    return;
                }
                this.errorProviderName.SetError(comboBoxNoms, "");
                comboBoxNoms.Items.Add(comboBoxNoms.Text);
                checkButtonEnabled();
            }
        }

        private void comboBoxNoms_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkButtonEnabled();
        }

        private void checkButtonEnabled()
        {
            buttonSup.Enabled = comboBoxNoms.SelectedIndex >= 0;
            buttonTresSup.Enabled = comboBoxNoms.Items.Count > 0;
            buttonInf.Enabled = listBoxCible.SelectedIndex >= 0;
            buttonTresInf.Enabled = listBoxCible.Items.Count > 0;
            buttonHaut.Enabled = listBoxCible.SelectedIndex >= 1;
            buttonBas.Enabled = listBoxCible.SelectedIndex >= 0 && listBoxCible.SelectedIndex < listBoxCible.Items.Count - 1;
            comboBoxNoms.Text = "";

        }

        private void listBoxCible_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkButtonEnabled();
        }

        private void buttonSup_Click(object sender, EventArgs e)
        {
            object itemToTransfer = comboBoxNoms.Items[comboBoxNoms.SelectedIndex];
            listBoxCible.Items.Add(itemToTransfer);
            comboBoxNoms.Items.Remove(itemToTransfer);

            checkButtonEnabled();

        }

        private void buttonInf_Click(object sender, EventArgs e)
        {
            int index = listBoxCible.SelectedIndex;
            object itemToTransfer = listBoxCible.Items[index];
            comboBoxNoms.Items.Add(itemToTransfer);
            listBoxCible.Items.Remove(itemToTransfer);
            if (index >= listBoxCible.Items.Count)
            {
                index--;
            }
            listBoxCible.SelectedIndex = index;
            checkButtonEnabled();
        }

        private void buttonTresSup_Click(object sender, EventArgs e)
        {
            foreach (var item in comboBoxNoms.Items)
            {
                listBoxCible.Items.Add(item);
            }
            comboBoxNoms.Items.Clear();
            checkButtonEnabled();
        }

        private void buttonTresInf_Click(object sender, EventArgs e)
        {
            foreach (var item in listBoxCible.Items)
            {
                comboBoxNoms.Items.Add(item);
            }
            listBoxCible.Items.Clear();
            checkButtonEnabled();
        }

        private void buttonHaut_Click(object sender, EventArgs e)
        {
            int sel = listBoxCible.SelectedIndex;
            listBoxCible.Items.Swap(sel, sel - 1);
            listBoxCible.SelectedIndex = sel - 1;
            checkButtonEnabled();
        }

        private void buttonBas_Click(object sender, EventArgs e)
        {
            int sel = listBoxCible.SelectedIndex;
            listBoxCible.Items.Swap(sel, sel + 1);
            listBoxCible.SelectedIndex = sel + 1;
            checkButtonEnabled();
        }
    }
}
