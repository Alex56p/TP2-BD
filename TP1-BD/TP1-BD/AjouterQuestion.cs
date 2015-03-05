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
            //OracleCommand oraAjout = new OracleCommand("GESTIONEMPLOYES", Connexion.oraconn);

            //oraAjout.CommandText = "GESTIONEMPLOYES.INSERTION";
            //oraAjout.CommandType = CommandType.StoredProcedure;

            //OracleParameter oraPNUMEMP = new OracleParameter("PNUMEMP", OracleDbType.Int32);
            //oraPNUMEMP.Direction = ParameterDirection.Input;
            //oraPNUMEMP.Value = TB_Add_NumEmp.Text;
            //oraAjout.Parameters.Add(oraPNUMEMP);

            //OracleParameter oraNOMEMP = new OracleParameter("PNOMEMP", OracleDbType.Varchar2, 50);
            //oraNOMEMP.Direction = ParameterDirection.Input;
            //oraNOMEMP.Value = TB_Add_NomEmp.Text;
            //oraAjout.Parameters.Add(oraNOMEMP);

            //OracleParameter oraPPRENOMEMP = new OracleParameter("PPRENOMEMP", OracleDbType.Varchar2, 50);
            //oraPPRENOMEMP.Direction = ParameterDirection.Input;
            //oraPPRENOMEMP.Value = TB_Add_PrenomEmp.Text;
            //oraAjout.Parameters.Add(oraPPRENOMEMP);

            //OracleParameter oraPSALAIREEMP = new OracleParameter("PSALAIREEMP", OracleDbType.Int32);
            //oraPSALAIREEMP.Direction = ParameterDirection.Input;
            //oraPSALAIREEMP.Value = TB_Add_SalaireEmp.Text;
            //oraAjout.Parameters.Add(oraPSALAIREEMP);

            //OracleParameter oraPCODEDEPEMP = new OracleParameter("PCODEDEPEMP", OracleDbType.Char, 3);
            //oraPCODEDEPEMP.Direction = ParameterDirection.Input;
            //oraPCODEDEPEMP.Value = TB_Add_CodeDepEmp.Text;
            //oraAjout.Parameters.Add(oraPCODEDEPEMP);

            //oraAjout.ExecuteNonQuery();

        }
    }
}
