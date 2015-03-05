using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1_BD
{
    public partial class ChoisirCategorie : Form
    {
        public int Categorie;
        public ChoisirCategorie()
        {
            InitializeComponent();
            Check();
        }

        private void Check()
        {
            if (!RB_Divertissement.Checked && !RB_JV.Checked && !RB_Sciences.Checked && !RB_Sport.Checked)
                BTN_OK.Enabled = false;
            else
                BTN_OK.Enabled = true;
        }

        private void RB_Sciences_CheckedChanged(object sender, EventArgs e)
        {
            Check();
            Categorie = 1;
        }

        private void RB_Sport_CheckedChanged(object sender, EventArgs e)
        {
            Check();
            Categorie = 2;
        }

        private void RB_JV_CheckedChanged(object sender, EventArgs e)
        {
            Check();
            Categorie = 3;
        }

        private void RB_Divertissement_CheckedChanged(object sender, EventArgs e)
        {
            Check();
            Categorie = 4;
        }

        private void BTN_OK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

     

    }
}
