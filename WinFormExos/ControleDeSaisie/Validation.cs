using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleDeSaisie
{
    public partial class Validation : Form
    {
        public Validation(string nom, string date, string montant, string codePostal)
        {
            InitializeComponent();
            EcrireNom.Text = nom;
            EcrireDate.Text = date;
            EcrireMontant.Text = montant;
            EcrireCode.Text = codePostal;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
