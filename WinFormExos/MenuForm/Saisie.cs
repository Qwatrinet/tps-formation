using CheckboxRadios;
using System;
using System.Windows.Forms;

namespace MenuForm
{
    public partial class Saisie : Form
    {
        string text;
        public Saisie()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            text = textBox1.Text;
            Form f = new CheckBoxForm(text);
            f.MdiParent = this.MdiParent;
            f.Show();
            this.Close();
        }
    }
}
