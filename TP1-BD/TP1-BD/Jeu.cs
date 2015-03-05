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
            int cat = random.Next(1, 5);
            if (cat == 1)
                PN_Categorie.BackColor = Color.FromArgb(0, 192, 0);
            else if (cat == 2)
                PN_Categorie.BackColor = Color.FromArgb(255, 128, 0);
            else if (cat == 3)
                PN_Categorie.BackColor = Color.FromArgb(255, 128, 0);
            else if (cat == 4)
                PN_Categorie.BackColor = Color.Blue;
            else if (cat == 5)
            {
                PN_Categorie.BackColor = Color.White;

            }

            RepondreQuestion rep = new RepondreQuestion(cat);
            Thread.Sleep(2000);
            rep.ShowDialog();

        }
    }
}
