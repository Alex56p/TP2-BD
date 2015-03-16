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
    public partial class StatsJoueur : Form
    {
        string Alias;
        /// <summary>
        /// Constructeurs
        /// </summary>
        #region Constructeurs
        public StatsJoueur()
        {
            InitializeComponent();
            AfficherAlias();
            AfficherStatsGenerales();
            AfficherStatsCategories();
        }

        public StatsJoueur(string alias)
        {
            InitializeComponent();

            // CB
            Alias = alias;
            AfficherAlias();
            CB_Alias.SelectedItem = alias;

            // Afficher Stats
            AfficherStatsGenerales();
            AfficherStatsCategories();
        }
        #endregion

        /// <summary>
        /// Stats Générales
        /// </summary>
        #region Stats Générales
        private void AfficherStatsGenerales()
        {
            AfficherNombrePartiesJoues();
            AfficherVictoiresDefaites();
            AfficherQuestionsReussitesRates();
        }

        private void AfficherAlias()
        {
            string SQLAfficher = "SELECT USERNAME FROM JOUEURS";
            
            OracleCommand orcmd = new OracleCommand(SQLAfficher, Connexion.oraconn);
            orcmd.CommandType = CommandType.Text;
            OracleDataReader orareader = orcmd.ExecuteReader();

            while (orareader.Read())
            {
                CB_Alias.Items.Add(orareader.GetString(0));
            }
            if (Alias == null)
            {
                Alias = CB_Alias.Items[0].ToString();
                CB_Alias.SelectedItem = Alias;
            }
                
        }

        private void AfficherNombrePartiesJoues()
        {
            // Mettre la catégorie a Sp pour afficher seulement une categorie par match
            OracleCommand oraliste = new OracleCommand("GESTIONINTELLICRACK", Connexion.oraconn);
            oraliste.CommandText = "GESTIONINTELLICRACK.GetNbMatch";
            oraliste.CommandType = CommandType.StoredProcedure;

            // Return Value
            OracleParameter OrapameResultat = new OracleParameter("NbMatch", OracleDbType.Int32);
            OrapameResultat.Direction = ParameterDirection.ReturnValue;
            oraliste.Parameters.Add(OrapameResultat);

            // Paramètre Joueur1
            OracleParameter OraJ = new OracleParameter("P_J", OracleDbType.Varchar2, 30);
            OraJ.Value = Alias;
            OraJ.Direction = ParameterDirection.Input;
            oraliste.Parameters.Add(OraJ);

            oraliste.ExecuteNonQuery();

            TB_NbPartiesJoues.Text = oraliste.Parameters["NbMatch"].Value.ToString();
        }

        private void AfficherVictoiresDefaites()
        {
            // À FAIRE DANS SQL
        }

        private void AfficherQuestionsReussitesRates()
        {
            // À FAIRE DANS SQL (AJOUTER COLONNE REUSSITES)
        }
        #endregion

        /// <summary>
        /// Boutons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        #region Boutons
        private void CB_Alias_SelectedIndexChanged(object sender, EventArgs e)
        {
            Alias = CB_Alias.SelectedItem.ToString();
            AfficherStatsGenerales();
            AfficherStatsCategories();
        }
        #endregion

        #region Stats Catégories
        private void AfficherStatsCategories()
        {
            StatsSport();
            StatsDivertissement();
            StatsJeuxVideo();
            StatsScience();
        }

        private void StatsSport()
        {
            string SQLAfficher = "SELECT SUM(SCORE) FROM SCORES WHERE USERNAME = '" + Alias + "' AND CODECATEGORIE = 'Sp'";
            
            OracleCommand orcmd = new OracleCommand(SQLAfficher, Connexion.oraconn);
            orcmd.CommandType = CommandType.Text;
            OracleDataReader orareader = orcmd.ExecuteReader();

            if (orareader.Read())
            {
                TB_Sport.Text = orareader.GetInt32(0).ToString();
            }
        }

        private void StatsDivertissement()
        {
            string SQLAfficher = "SELECT SUM(SCORE) FROM SCORES WHERE USERNAME = '" + Alias + "' AND CODECATEGORIE = 'Di'";

            OracleCommand orcmd = new OracleCommand(SQLAfficher, Connexion.oraconn);
            orcmd.CommandType = CommandType.Text;
            OracleDataReader orareader = orcmd.ExecuteReader();

            if (orareader.Read())
            {
                TB_Divertissement.Text = orareader.GetInt32(0).ToString();
            }
        }

        private void StatsJeuxVideo()
        {
            string SQLAfficher = "SELECT SUM(SCORE) FROM SCORES WHERE USERNAME = '" + Alias + "' AND CODECATEGORIE = 'Jv'";

            OracleCommand orcmd = new OracleCommand(SQLAfficher, Connexion.oraconn);
            orcmd.CommandType = CommandType.Text;
            OracleDataReader orareader = orcmd.ExecuteReader();

            if (orareader.Read())
            {
                TB_JeuxVideo.Text = orareader.GetInt32(0).ToString();
            }

        }

        private void StatsScience()
        {
            string SQLAfficher = "SELECT SUM(SCORE) FROM SCORES WHERE USERNAME = '" + Alias + "' AND CODECATEGORIE = 'Sc'";

            OracleCommand orcmd = new OracleCommand(SQLAfficher, Connexion.oraconn);
            orcmd.CommandType = CommandType.Text;
            OracleDataReader orareader = orcmd.ExecuteReader();

            if (orareader.Read())
            {
                TB_Science.Text = orareader.GetInt32(0).ToString();
            }

        }
        #endregion
    }
}
