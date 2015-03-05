using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace TP1_BD
{
    public partial class Jeu : Form
    {
        String J1;
        String J2;
        String J3;
        String J4;
        public Jeu(String j1, String j2)
        {
            InitializeComponent();
            J1 = j1;
            J2 = j2;
            AfficherJoueurs();
        }
        public Jeu(String j1, String j2, String j3)
        {
            InitializeComponent();
            J1 = j1;
            J2 = j2;
            J3 = j3;
            AfficherJoueurs();
        }
        public Jeu(String j1, String j2, String j3, String j4)
        {
            InitializeComponent();
            J1 = j1;
            J2 = j2;
            J3 = j3;
            J4 = j4;
            AfficherJoueurs();
        }

        private void AfficherJoueurs()
        {
            TB_Classement1.Text = J1;
            TB_Classement2.Text = J2;
            if (J3 != null)
                TB_Classement3.Text = J3;
            else
                TB_Classement3.Text = "N/A";
            if(J4 != null)
                TB_Classement4.Text = J4;
            else 
                TB_Classement4.Text = "N/A";

            LB_Points1.Text = "0";
            LB_Points2.Text = "0";
            LB_Points3.Text = "0";
            LB_Points4.Text = "0";
        }

        private void BTN_DetailsClassement_Click(object sender, EventArgs e)
        {
            DetailsMatch detailsMatch = new DetailsMatch();
            detailsMatch.ShowDialog();
        }

        private void BTN_Tourner_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int cat = random.Next(1, 6);
            if (cat == 1)
            {
                PN_Categorie.BackColor = Color.Green;
                MessageBox.Show("Sciences");
            }
            else if (cat == 2)
            {
                PN_Categorie.BackColor = Color.Orange;
                MessageBox.Show("Sport");
            }
            else if (cat == 3)
            {
                PN_Categorie.BackColor = Color.Blue;
                MessageBox.Show("Jeu Vidéo");
            }
            else if (cat == 4)
            {
                PN_Categorie.BackColor = Color.Fuchsia;
                MessageBox.Show("Divertissement");
            }
            else if (cat == 5)
            {
                PN_Categorie.BackColor = Color.White;
                ChoisirCategorie choix = new ChoisirCategorie();
                if (choix.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    cat = choix.Categorie;
                }
            }
            
            /////////// À MODIFIER /////////// TEMPORAIRE PCQ IL MANQUE LES QUESTIONS DE SCIENCES ////////
            RepondreQuestion rep;
            if(cat != 1)
            {
                rep = new RepondreQuestion(cat);
            
                rep.ShowDialog();
            }
                 
        }
    }
}
