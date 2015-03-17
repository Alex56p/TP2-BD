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
    public partial class AjouterQuestion : Form
    {
        public AjouterQuestion()
        {
            InitializeComponent();
            CheckButton();
            AfficherCategories();
        }

        /// <summary>
        /// CheckButton
        /// Permet de vérifier s'il y a des champs vide pour l'insertion
        /// </summary>
        public void CheckButton()
        {
            if (TB_Question.Text != "" &&
                TB_BonneReponse.Text != "" &&
                TB_Reponse2.Text != "" &&
                TB_Reponse3.Text != "" &&
                TB_Reponse4.Text != "" &&
                CB_Categories.SelectedItem != null)
            {
                BTN_AjouterQuestion.Enabled = true;
            }
            else
            {
                BTN_AjouterQuestion.Enabled = false;
            }
        }

        /// <summary>
        /// AfficherCategories
        /// Permet d'afficher les catégories dans le combobox
        /// </summary>
        private void AfficherCategories()
        {
            string SQLAfficher = "SELECT NOMCATEGORIE FROM CATEGORIES";
            OracleCommand orcmd1 = new OracleCommand(SQLAfficher, Connexion.oraconn);
            orcmd1.CommandType = CommandType.Text;
            OracleDataReader oraread = orcmd1.ExecuteReader();

            while (oraread.Read())
            {
                CB_Categories.Items.Add(oraread.GetString(0));
            }
            oraread.Close();
        }

        /// <summary>
        /// S'assurer que les TB et CB contiennent quelque chose avant d'inserer la question
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        #region TB et CB
        private void CB_Categories_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckButton();
        }

        private void TB_Question_TextChanged(object sender, EventArgs e)
        {
            CheckButton();
        }

        private void TB_BonneReponse_TextChanged(object sender, EventArgs e)
        {
            CheckButton();
        }

        private void TB_Reponse2_TextChanged(object sender, EventArgs e)
        {
            CheckButton();
        }

        private void TB_Reponse3_TextChanged(object sender, EventArgs e)
        {
            CheckButton();
        }

        private void TB_Reponse4_TextChanged(object sender, EventArgs e)
        {
            CheckButton();
        }
        #endregion

        /// <summary>
        /// AjouterQuestion
        /// Permet d'ajouter une question à la BD
        /// </summary>
        private void AjouterUneQuestion()
        {
            OracleCommand oraAjout = new OracleCommand("GESTIONINTELLICRACK", Connexion.oraconn);

            oraAjout.CommandText = "GESTIONINTELLICRACK.Ajouter_Question";
            oraAjout.CommandType = CommandType.StoredProcedure;

            // Categorie
            OracleParameter oraP_Categorie = new OracleParameter("P_CATEGORIE", OracleDbType.Char, 2);
            oraP_Categorie.Direction = ParameterDirection.Input;
            oraP_Categorie.Value = GetCodeCategorie(CB_Categories.SelectedItem.ToString());
            oraAjout.Parameters.Add(oraP_Categorie);

            // Question
            OracleParameter oraQUESTION = new OracleParameter("P_Q", OracleDbType.Varchar2, 150);
            oraQUESTION.Direction = ParameterDirection.Input;
            oraQUESTION.Value = TB_Question.Text;
            oraAjout.Parameters.Add(oraQUESTION);

            // Bonne Réponse
            OracleParameter oraPR1 = new OracleParameter("P_R1", OracleDbType.Varchar2, 50);
            oraPR1.Direction = ParameterDirection.Input;
            oraPR1.Value = TB_BonneReponse.Text;
            oraAjout.Parameters.Add(oraPR1);

            // Réponse 2
            OracleParameter oraPR2 = new OracleParameter("P_R2", OracleDbType.Varchar2, 50);
            oraPR2.Direction = ParameterDirection.Input;
            oraPR2.Value = TB_Reponse2.Text;
            oraAjout.Parameters.Add(oraPR2);

            // Réponse 3
            OracleParameter oraPR3 = new OracleParameter("P_R3", OracleDbType.Varchar2, 50);
            oraPR3.Direction = ParameterDirection.Input;
            oraPR3.Value = TB_Reponse3.Text;
            oraAjout.Parameters.Add(oraPR3);

            // Réponse 4
            OracleParameter oraPR4 = new OracleParameter("P_R4", OracleDbType.Char, 3);
            oraPR4.Direction = ParameterDirection.Input;
            oraPR4.Value = TB_Reponse4.Text;
            oraAjout.Parameters.Add(oraPR4);

            oraAjout.ExecuteNonQuery();

            // Afficher un message disant que la question à été ajoutée
            MessageBox.Show("La question à été ajoutée avec Succès!");
        }
        /// <summary>
        /// GetCodeCategorie
        /// Permet de retourner le code de la catégorie avec le nom de celle-ci
        /// </summary>
        /// <param name="nom"></param>
        /// <returns></returns>
        private string GetCodeCategorie(string nom)
        {
            string codeCategorie = "";
            string SQLCode = "SELECT CODECATEGORIE FROM CATEGORIES WHERE NOMCATEGORIE = '" + nom + "'";

            OracleCommand orcmd = new OracleCommand(SQLCode, Connexion.oraconn);
            orcmd.CommandType = CommandType.Text;
            OracleDataReader orareader = orcmd.ExecuteReader();

            if (orareader.Read())
            {
                codeCategorie = orareader.GetString(0);
            }
            orareader.Close();

            //oraAjout.ExecuteNonQuery();
            return codeCategorie;
        }

        /// <summary>
        /// BTN_AjouterQuestion_Click
        /// Permet d'ajouter la question quand le bouton est sélectionné
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_AjouterQuestion_Click(object sender, EventArgs e)
        {
            AjouterUneQuestion();
        }
    }
}