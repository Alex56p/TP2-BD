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
    public partial class DetailsMatch : Form
    {
        private DataSet JoueursDS = new DataSet();
        bool Lier = false;

        public DetailsMatch()
        {
            InitializeComponent();
            LB_Alias.Text = Jeu.Premier;
            AfficherJoueur();
            AfficherPoints();
        }

        /// <summary>
        /// Boutons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        #region Boutons
        private void BTN_Statistiques_Click(object sender, EventArgs e)
        {
            StatsJoueur stats = new StatsJoueur(LB_Alias.Text);
            stats.ShowDialog();
        }

        private void BTN_Precedent_Click(object sender, EventArgs e)
        {
            this.BindingContext[JoueursDS, "SCORES"].Position -= 1;
            TB_PositionClassement.Text = (this.BindingContext[JoueursDS, "SCORES"].Position + 1).ToString();
            AfficherPoints();
        }

        private void BTN_Suivant_Click(object sender, EventArgs e)
        {
            this.BindingContext[JoueursDS, "SCORES"].Position += 1;
            TB_PositionClassement.Text = (this.BindingContext[JoueursDS, "SCORES"].Position + 1).ToString();
            AfficherPoints();
        }
        #endregion

        /// <summary>
        /// Affichage
        /// </summary>
        #region Affichage
        private void AfficherJoueur()
        {
            string SQLAFFICHER = "SELECT USERNAME FROM SCORES WHERE NUMMATCH = " + Jeu.NumMatch + " GROUP BY USERNAME ORDER BY SUM(SCORE) DESC";
            OracleCommand orcmd1 = new OracleCommand(SQLAFFICHER, Connexion.oraconn);
            orcmd1.CommandType = CommandType.Text;
            OracleDataReader oraread = orcmd1.ExecuteReader();
            if (oraread.Read())
            {
                OracleDataAdapter Adapter1 = new OracleDataAdapter(SQLAFFICHER, Connexion.oraconn);
                if (JoueursDS.Tables.Contains("SCORES"))
                    JoueursDS.Tables["SCORES"].Clear();

                Adapter1.Fill(JoueursDS, "SCORES");
                Adapter1.Dispose();

                if(!Lier)
                    LierJoueur();

                TB_PositionClassement.Text = (this.BindingContext[JoueursDS, "SCORES"].Position + 1).ToString();
            }
            oraread.Close();

            // Afficher les points du joueur
            AfficherPoints();
        }

        private void LierJoueur()
        {
            LB_Alias.DataBindings.Add("text", JoueursDS, "SCORES.USERNAME");
            Lier = true;
        }

        private void AfficherPoints()
        {
            TB_JeuxVideo.BackColor = SystemColors.Control;
            TB_Divertissement.BackColor = SystemColors.Control;
            TB_Science.BackColor = SystemColors.Control;
            TB_Sport.BackColor = SystemColors.Control;


            string SQLAfficher = "SELECT SCORE FROM SCORES WHERE NUMMATCH = " + Jeu.NumMatch + " AND USERNAME = '" + LB_Alias.Text + "' ORDER BY CODECATEGORIE";
            OracleCommand orcmd1 = new OracleCommand(SQLAfficher, Connexion.oraconn);
            orcmd1.CommandType = CommandType.Text;
            OracleDataReader oraread = orcmd1.ExecuteReader();
            if (oraread.Read())
            {
                TB_Divertissement.Text = oraread.GetInt32(0).ToString();
            }
            if(oraread.Read())
            {
                TB_JeuxVideo.Text = oraread.GetInt32(0).ToString();
            }
            if(oraread.Read())
            {
                TB_Science.Text = oraread.GetInt32(0).ToString();
            }
            if(oraread.Read())
            {
                TB_Sport.Text = oraread.GetInt32(0).ToString();
            }

            AfficherPireCategorie();
            AfficherCategoriesGagnees();
            oraread.Close();
        }

        private void AfficherPireCategorie()
        {
            OracleCommand oraliste = new OracleCommand("GESTIONINTELLICRACK", Connexion.oraconn);
            oraliste.CommandText = "GESTIONINTELLICRACK.Afficher_Pire_Categorie";
            oraliste.CommandType = CommandType.StoredProcedure;

            // Return Value
            OracleParameter OrapameResultat = new OracleParameter("Categories", OracleDbType.Char,2);
            OrapameResultat.Direction = ParameterDirection.ReturnValue;
            oraliste.Parameters.Add(OrapameResultat);

            // Paramètre Joueur1
            OracleParameter OraJ1 = new OracleParameter("F_J1", OracleDbType.Varchar2, 30);
            OraJ1.Value = LB_Alias.Text;
            OraJ1.Direction = ParameterDirection.Input;
            oraliste.Parameters.Add(OraJ1);

            // Paramètre Joueur1
            OracleParameter OraNumMatch = new OracleParameter("FNumMatch", OracleDbType.Int32);
            OraNumMatch.Value = Jeu.NumMatch;
            OraNumMatch.Direction = ParameterDirection.Input;
            oraliste.Parameters.Add(OraNumMatch);

            try
            {
                oraliste.ExecuteNonQuery();
                string cat = oraliste.Parameters["Categories"].Value.ToString();

                if (cat == "Sp")
                    TB_Sport.BackColor = Color.IndianRed;
                else if (cat == "Sc")
                    TB_Science.BackColor = Color.IndianRed;
                else if (cat == "Di")
                    TB_Divertissement.BackColor = Color.IndianRed;
                else if (cat == "Jv")
                    TB_JeuxVideo.BackColor = Color.IndianRed;
             }
            catch(Exception ex)
            {

            }
            
        }

        private void AfficherCategoriesGagnees()
        {
            OracleCommand oraliste = new OracleCommand("GESTIONINTELLICRACK", Connexion.oraconn);
            oraliste.CommandText = "GESTIONINTELLICRACK.Afficher_Categorie_Gagne";
            oraliste.CommandType = CommandType.StoredProcedure;

            // Return Value
            OracleParameter OrapameResultat = new OracleParameter("Categories", OracleDbType.RefCursor);
            OrapameResultat.Direction = ParameterDirection.ReturnValue;
            oraliste.Parameters.Add(OrapameResultat);

            // Paramètre Joueur1
            OracleParameter OraJ1 = new OracleParameter("F_J1", OracleDbType.Varchar2, 30);
            OraJ1.Value = LB_Alias.Text;
            OraJ1.Direction = ParameterDirection.Input;
            oraliste.Parameters.Add(OraJ1);

            // Paramètre Joueur1
            OracleParameter OraNumMatch = new OracleParameter("FNumMatch", OracleDbType.Int32);
            OraNumMatch.Value = Jeu.NumMatch;
            OraNumMatch.Direction = ParameterDirection.Input;
            oraliste.Parameters.Add(OraNumMatch);

            OracleDataReader oraread = oraliste.ExecuteReader();

            while(oraread.Read())
            {
                if (oraread.GetString(0) == "Sc")
                    TB_Science.BackColor = Color.LightGreen;
                else if (oraread.GetString(0) == "Sp")
                    TB_Sport.BackColor = Color.LightGreen;
                else if (oraread.GetString(0) == "Di")
                    TB_Divertissement.BackColor = Color.LightGreen;
                else if (oraread.GetString(0) == "Jv")
                    TB_JeuxVideo.BackColor = Color.LightGreen;
             }
        }
        #endregion
    }
}
