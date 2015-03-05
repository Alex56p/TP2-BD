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
    public partial class Jeu : Form
    {
        public Jeu()
        {
            //Joueurs joueurs = new Joueurs();
            //joueurs.ShowDialog();
            //if(joueurs.DialogResult == System.Windows.Forms.DialogResult.OK)
            //{
            //    InitializeComponent();
            //}
            //else
            //{
            //    this.Close();
            //}

        }

        private void BTN_DetailsClassement_Click(object sender, EventArgs e)
        {
            DetailsMatch detailsMatch = new DetailsMatch();
            detailsMatch.ShowDialog();
        }
    }
}
