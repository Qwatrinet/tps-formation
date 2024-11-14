using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraouCalculateur
{
    public partial class Form1 : Form
    {
        int resultat = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            Button numberBtn = (Button)sender;
            
            int toAdd;
            if (int.TryParse((string)numberBtn.Tag,out toAdd))
            {
                resultat += toAdd;

                resultatCalcul.Text += numberBtn.Tag+"+";
            }
        }

        private void buttonVider_Click(object sender, EventArgs e)
        {
            resultatCalcul.Text = "";
            resultat = 0;
        }

        private void buttonCalculer_Click(object sender, EventArgs e)
        {
            resultatCalcul.Text += " = " + resultat+"+";
        }
    }
}
