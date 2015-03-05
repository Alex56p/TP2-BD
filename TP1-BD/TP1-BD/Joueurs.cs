using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace TP1_BD
{
    public partial class Joueurs : Form
    {
        OracleConnection conn;
        String Alias;
        public Joueurs(String alias, OracleConnection oraconn)
        {
            Alias = alias;
            conn = oraconn;
            InitializeComponent();
            CheckComboBox();
            CheckButton();
            AfficherJoueurs();
        }

   
        private void BTN_CreerJoueur_Click(object sender, EventArgs e)
        {
            Inscription inscription = new Inscription();
            inscription.ShowDialog();
            AfficherJoueurs();
        }

        private void BTN_CommencerPartie_Click(object sender, EventArgs e)
        {
            if(CanStart())
            {
                Jeu jeu;
                if(CB_Joueur4.SelectedItem != null)
                    jeu = new Jeu(Alias,CB_Joueur2.SelectedItem.ToString(), CB_Joueur3.SelectedItem.ToString(), CB_Joueur4.SelectedItem.ToString());
                else if(CB_Joueur3.SelectedItem != null)
                    jeu = new Jeu(Alias, CB_Joueur2.SelectedItem.ToString(), CB_Joueur3.SelectedItem.ToString());
                else 
                    jeu = new Jeu(Alias, CB_Joueur2.SelectedItem.ToString());
                jeu.ShowDialog();
            }
            else
            {
                MessageBox.Show("Un joueur ne peut être présent qu'une seule fois par match.");
            }
        }

        private void AfficherJoueurs()
        {
            CB_Joueur2.Items.Clear();
            CB_Joueur3.Items.Clear();
            CB_Joueur4.Items.Clear();

            string SQLAfficher = "SELECT USERNAME FROM JOUEURS WHERE USERNAME != '" + Alias + "'";
            OracleCommand orcmd1 = new OracleCommand(SQLAfficher, conn);
            orcmd1.CommandType = CommandType.Text;
            OracleDataReader oraread = orcmd1.ExecuteReader();

            while (oraread.Read())
            {
                CB_Joueur2.Items.Add(oraread.GetString(0));
                CB_Joueur3.Items.Add(oraread.GetString(0));
                CB_Joueur4.Items.Add(oraread.GetString(0));
            }
        }

        private bool CanStart()
        {
            if (CB_Joueur2.SelectedItem != null)
            {
                if (CB_Joueur3.SelectedItem != null)
                {
                    if (CB_Joueur3.SelectedItem.ToString() == CB_Joueur2.SelectedItem.ToString())
                        return false;
                    if (CB_Joueur4.SelectedItem != null)
                    {
                        if (CB_Joueur4.SelectedItem.ToString() == CB_Joueur2.SelectedItem.ToString())
                            return false;
                        if (CB_Joueur4.SelectedItem.ToString() == CB_Joueur3.SelectedItem.ToString())
                            return false;
                        return true;
                    }
                }
            }
            else
                return false;
            return true;
        }

        private void CheckComboBox()
        {
            if(CB_Joueur2.SelectedItem == null)
            {
                CB_Joueur3.Enabled = false;
                CB_Joueur4.Enabled = false;
            }
            else 
            {
                CB_Joueur3.Enabled = true;
            }


            if (CB_Joueur3.SelectedItem == null)
            {

                CB_Joueur4.Enabled = false;
            }
            else
            {
                CB_Joueur4.Enabled = true;
            }
        }
        private void CheckButton()
        {
            if (CB_Joueur2.SelectedItem == null)
                BTN_CommencerPartie.Enabled = false;
            else
                BTN_CommencerPartie.Enabled = true;
        }


        private void CB_Joueur2_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckComboBox();
            CheckButton();
        }

        private void CB_Joueur3_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckComboBox();
            CheckButton();
        }
    }
}
