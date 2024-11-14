using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Couleurs
{
    public partial class CouleurForm : Form
    {
        Color color;

        public CouleurForm()
        {
            InitializeComponent();
            color = Color.Black;
            UpdateViewFromModel();
        }

        private void UpdateViewFromModel()
        {

            int redLevel = color.R;
            int greenLevel = color.G;
            int blueLevel = color.B;

            panelRouge.BackColor= Color.FromArgb(redLevel, 0, 0);
            numericUpDownRouge.Value = redLevel;
            hScrollBarRouge.Value = redLevel;

            panelVert.BackColor = Color.FromArgb(0, greenLevel, 0);
            hScrollBarVert.Value = greenLevel;
            numericUpDownVert.Value = greenLevel;

            panelBleu.BackColor= Color.FromArgb(0, 0, blueLevel);
            hScrollBarBleu.Value = blueLevel;
            numericUpDownBleu.Value = blueLevel;

            panelTotal.BackColor = color;

        }

        //private void SetPanelTotalValue()
        //{
        //    panelTotal.BackColor = Color.FromArgb((int)numericUpDownRouge.Value, (int)numericUpDownVert.Value, (int)numericUpDownBleu.Value);
        //}

        private void numericUpDownRouge_ValueChanged(object sender, EventArgs e)
        {
            color= Color.FromArgb((int)numericUpDownRouge.Value,color.G,color.B);
            UpdateViewFromModel();
            //hScrollBarRouge.Value = newValue;
            //panelRouge.BackColor = Color.FromArgb(newValue, 0, 0);
            //SetPanelTotalValue();
        }

        private void numericUpDownVert_ValueChanged(object sender, EventArgs e)
        {
            color = Color.FromArgb(color.R, (int)numericUpDownVert.Value, color.B);
            UpdateViewFromModel();
            //int newValue = (int)numericUpDownVert.Value;
            //hScrollBarVert.Value = newValue;
            //panelVert.BackColor = Color.FromArgb(0, newValue, 0);
            //SetPanelTotalValue();
        }

        private void numericUpDownBleu_ValueChanged(object sender, EventArgs e)
        {
            color = Color.FromArgb(color.R, color.G, (int)numericUpDownBleu.Value);
            UpdateViewFromModel();
            //int newValue = (int)numericUpDownBleu.Value;
            //hScrollBarBleu.Value = newValue;
            //panelBleu.BackColor = Color.FromArgb(0, 0, newValue);
            //SetPanelTotalValue();
        }




        private void hScrollBarVert_Scroll(object sender, ScrollEventArgs e)
        {
            color = Color.FromArgb(color.R, e.NewValue, color.B);
            UpdateViewFromModel();
            //int newValue = e.NewValue;
            //numericUpDownVert.Value = newValue;
            //panelVert.BackColor = Color.FromArgb(0, newValue, 0);
            //SetPanelTotalValue();
        }

        private void hScrollBarBleu_Scroll(object sender, ScrollEventArgs e)
        {
            color = Color.FromArgb(color.R, color.G, e.NewValue);
            UpdateViewFromModel();
            //int newValue = e.NewValue;
            //numericUpDownBleu.Value = newValue;
            //panelBleu.BackColor = Color.FromArgb(0, 0, newValue);
            //SetPanelTotalValue();
        }

        private void hScrollBarRouge_Scroll(object sender, ScrollEventArgs e)
        {
            color = Color.FromArgb(e.NewValue, color.G, color.B);
            UpdateViewFromModel();
            //int newValue= e.NewValue;
            //numericUpDownRouge.Value = newValue;
            //panelRouge.BackColor= Color.FromArgb(newValue, 0, 0);
            //SetPanelTotalValue();

        }

        private void panelTotal_Click(object sender, EventArgs e)
        {
            Clipboard.SetText($"rgb({color.R}, {color.G}, {color.B})");
            //Clipboard.SetDataObject(color);
        }
    }
}
