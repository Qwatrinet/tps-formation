using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testWinform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.textBox1.Text = "truite";

        }

        private void buttonBonjour_Click(object sender, EventArgs e)
        {
            bobForm bob=new bobForm();
            DialogResult dr=bob.ShowDialog();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string nouveauTexte=textBox1.Text;
        }
    }
}
