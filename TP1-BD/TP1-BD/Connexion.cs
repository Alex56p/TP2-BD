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
    public partial class Connexion : Form
    {
        // Connexion à la base de données
        public static OracleConnection oraconn = new OracleConnection();

        public String Alias;

        public Connexion()
        {
            InitializeComponent();
            Login();
            CheckButton();
        }

        /// <summary>
        /// Login
        /// Fonction qui permet de se connecter à la base de données
        /// </summary>
        private void Login()
        {
            string Dsource = "(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)" +
            "(HOST=205.237.244.251)(PORT=1521)))" + "(CONNECT_DATA=(SERVICE_NAME=ORCL.clg.qc.ca)))";

            string user = "labellev";
            string passwd = "ORACLE1";
            string chaineconnexion = "Data Source = " + Dsource + ";User ID = " + user + ";Password = " + passwd;

            try
            {
                oraconn.ConnectionString = chaineconnexion;
                oraconn.Open();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message.ToString());
            }
        }

        /// <summary>
        /// BTN_Inscription_Click
        /// Permet de créer un nouveau joueur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_Inscription_Click(object sender, EventArgs e)
        {
            Inscription inscription = new Inscription();
            inscription.ShowDialog();
        }

        /// <summary>
        /// BTN_Connexion_Click
        /// Permet de regarder si l'Alias est valide pour ensuite amener au menu principal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_Connexion_Click(object sender, EventArgs e)
        {
            if(!ConnexionJoueur())
            {
                MessageBox.Show("Le nom d'utilisateur n'existe pas");
            }
            else
            {
                Alias = TB_Alias.Text;
            }
        }
        
        /// <summary>
        /// CheckButton
        /// Permet de disable le boutton Connexion s'il n'y a rien dans TB_Alias
        /// </summary>
        private void CheckButton()
        {
            // Regarder si TB_Alias est vide
            if(TB_Alias.Text != "")
            {
                BTN_Connexion.Enabled = true;

                // Regarder si l'Alias existe pour pouvoir quitter le form quand BTN_Connexion est sélectionné
                if(ConnexionJoueur())
                {
                    BTN_Connexion.DialogResult = System.Windows.Forms.DialogResult.OK;
                }
                else
                {
                    BTN_Connexion.DialogResult = System.Windows.Forms.DialogResult.None;
                }
            }
            else
            {
                BTN_Connexion.Enabled = false;
                BTN_Connexion.DialogResult = System.Windows.Forms.DialogResult.None;
            }
        }

        /// <summary>
        /// ConnexionJoueur
        /// Permet de regarder si l'Alias existe dans la BD
        /// </summary>
        private bool ConnexionJoueur()
        {
            String SQLAlias = "SELECT USERNAME FROM JOUEURS WHERE USERNAME = '" + TB_Alias.Text + "'";

            OracleCommand orcmd = new OracleCommand(SQLAlias, oraconn);
            orcmd.CommandType = CommandType.Text;
            OracleDataReader orareader = orcmd.ExecuteReader();
            
            if (orareader.Read())
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        /// <summary>
        /// TB_Alias_TextChanged
        /// Permet de changer le Enable sur BTN_Connexion si le texte est vide ou non
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TB_Alias_TextChanged(object sender, EventArgs e)
        {
            CheckButton();
        }
    }
}
