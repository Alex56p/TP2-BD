﻿using Oracle.DataAccess.Client;
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
    public partial class MenuPrincipal : Form
    {
        public static String Alias;

        public MenuPrincipal()
        {
            Connexion conn = new Connexion();
            conn.ShowDialog();
            while (conn.DialogResult != System.Windows.Forms.DialogResult.OK)
            {
               conn.ShowDialog();
            }
            Alias = conn.Alias;

            InitializeComponent();


            AfficherTB();
        }

        #region Bouttons
        /// <summary>
        /// BTN_Statistiques_Click
        /// Permet d'afficher le form Statistiques
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_Statistiques_Click(object sender, EventArgs e)
        {
            StatsJoueur Stats = new StatsJoueur();
            Stats.ShowDialog();
        }

        /// <summary>
        /// BTN_Quitter_Click
        /// Permet de quitter l'application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_Quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// BTN_CommencerPartie_Click
        /// Permet de commencer une nouvelle partie
        /// 1) Choisir les joueurs
        /// 2) Commencer la partie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_CommencerPartie_Click(object sender, EventArgs e)
        {
            Joueurs joueurs = new Joueurs(Alias,Connexion.oraconn);
            joueurs.ShowDialog();
        }

        /// <summary>
        /// BTN_AjouterQuestion_Click
        /// Permet d'ouvrir le form AjouterQuestion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_AjouterQuestion_Click(object sender, EventArgs e)
        {
            if(TB_Alias.Text == "Admin")
            {
                AjouterQuestion ajouterQuestion = new AjouterQuestion();
                ajouterQuestion.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vous devez être Admin pour ajouter des questions.");
            }
            
        }
        #endregion

        /// <summary>
        /// AfficherTB
        /// Permet d'afficher les informations du joueur dans les TB
        /// </summary>
        private void AfficherTB()
        {
            String SQLJoueur = "SELECT USERNAME, NOM, PRENOM FROM JOUEURS WHERE USERNAME = '" + Alias + "'";

            OracleCommand orcmd = new OracleCommand(SQLJoueur, Connexion.oraconn);
            orcmd.CommandType = CommandType.Text;
            OracleDataReader orareader = orcmd.ExecuteReader();

            if (orareader.Read())
            {
                TB_Alias.Text = orareader.GetString(0);
                TB_Nom.Text = orareader.GetString(1);
                TB_Prenom.Text = orareader.GetString(2);
            }
            orareader.Close();
        }
    }
}
