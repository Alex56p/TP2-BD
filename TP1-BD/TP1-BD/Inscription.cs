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
    public partial class Inscription : Form
    {
        public Inscription()
        {
            InitializeComponent();
            CheckButton();
            CheckAlias();
        }

        /// <summary>
        /// CheckButton
        /// Permet de changer le enable sur le boutton ajouter quand les text box ne sont pas vide
        /// </summary>
        public void CheckButton()
        {
            if(TB_Alias.Text != "" && TB_Nom.Text != "" && TB_Prenom.Text != "")
            {
                BTN_Ok.Enabled = true;
                CheckAlias();
            }
            else
            {
                BTN_Ok.Enabled = false;
            }
        }

        /// <summary>
        /// Permet d'appeler la fonction CheckButton dès qu'un TB est changé
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        #region TB
        private void TB_Alias_TextChanged(object sender, EventArgs e)
        {
            CheckButton();
        }

        private void TB_Prenom_TextChanged(object sender, EventArgs e)
        {
            CheckButton();
        }

        private void TB_Nom_TextChanged(object sender, EventArgs e)
        {
            CheckButton();
        }
        #endregion

        /// <summary>
        /// BTN_Ok_Click
        /// Permet d'ajouter le joueur à la BD
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_Ok_Click(object sender, EventArgs e)
        {
            if(!CheckAlias())
            {
                AjouterJoueur();
            }
            else
            {
                MessageBox.Show("Erreur, l'Alias " + TB_Alias.Text + " existe déjà!");
            }
        }

        /// <summary>
        /// AjouterJoueur
        /// Permet d'ajouter un joueur à la BD
        /// </summary>
        private void AjouterJoueur()
        {
            string SQLAjouterDivision = "INSERT INTO JOUEURS VALUES (:alias, :nom, :prenom)";

            try
            {

                OracleParameter oraalias = new OracleParameter(":alias", OracleDbType.Varchar2, 30);
                OracleParameter oranom = new OracleParameter(":nom", OracleDbType.Varchar2, 30);
                OracleParameter oraprenom = new OracleParameter(":prenom", OracleDbType.Varchar2, 30);


                oraalias.Value = TB_Alias.Text;
                oranom.Value = TB_Nom.Text;
                oraprenom.Value = TB_Prenom.Text;

                OracleCommand oraAjout = new OracleCommand(SQLAjouterDivision, Connexion.oraconn);
                oraAjout.CommandType = CommandType.Text;

                oraAjout.Parameters.Add(oraalias);
                oraAjout.Parameters.Add(oranom);
                oraAjout.Parameters.Add(oraprenom);
                oraAjout.ExecuteNonQuery();

                MessageBox.Show("Le joueur a été ajouté");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());   
            }
        }

        /// <summary>
        /// CheckAlias
        /// Fonction qui permet de vérifier si l'Alias existe déjà dans la BD
        /// </summary>
        private bool CheckAlias()
        {
            String SQLAlias = "SELECT USERNAME FROM JOUEURS WHERE USERNAME = '" + TB_Alias.Text + "'";

            OracleCommand orcmd = new OracleCommand(SQLAlias, Connexion.oraconn);
            orcmd.CommandType = CommandType.Text;
            OracleDataReader orareader = orcmd.ExecuteReader();

            if (orareader.Read())
            {
                BTN_Ok.DialogResult = System.Windows.Forms.DialogResult.None;
                return true;
            }
            else
            {
                BTN_Ok.DialogResult = System.Windows.Forms.DialogResult.OK;
                return false;
            }
        }
    }
}
