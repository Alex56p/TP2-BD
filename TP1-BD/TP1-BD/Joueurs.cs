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
    public partial class Joueurs : Form
    {
        public Joueurs()
        {
            InitializeComponent();
        }

        private void BTN_CreerJoueur_Click(object sender, EventArgs e)
        {
            Inscription inscription = new Inscription();
            inscription.ShowDialog();
        }

        private void BTN_CommencerPartie_Click(object sender, EventArgs e)
        {
        }
    }
}
