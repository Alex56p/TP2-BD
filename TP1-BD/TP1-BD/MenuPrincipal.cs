using Oracle.DataAccess.Client;
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


      public MenuPrincipal()
      {
          Connexion conn = new Connexion();
          conn.ShowDialog();
          InitializeComponent();
          if(conn.DialogResult != System.Windows.Forms.DialogResult.OK)
          {
              this.Close();
          }


      }

      private void BTN_Statistiques_Click(object sender, EventArgs e)
      {
          StatsJoueur Stats = new StatsJoueur();
          Stats.ShowDialog();
      }

      private void BTN_Quitter_Click(object sender, EventArgs e)
      {
          this.Close();
      }

      private void BTN_CommencerPartie_Click(object sender, EventArgs e)
      {
          Jeu jeu = new Jeu();
          jeu.ShowDialog();
      }

      private void BTN_AjouterQuestion_Click(object sender, EventArgs e)
      {
          AjouterQuestion ajouterQuestion = new AjouterQuestion();
          ajouterQuestion.ShowDialog();
      }

      private void BTN_Classement_Click(object sender, EventArgs e)
      {
          Classement classement = new Classement();
          classement.ShowDialog();
      }
   }
}
