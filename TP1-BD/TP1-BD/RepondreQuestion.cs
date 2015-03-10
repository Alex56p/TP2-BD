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
    public partial class RepondreQuestion : Form
    {
        string Joueur;
        int Category;
        int Reponse1;
        int Reponse2;
        int Reponse3;
        int Reponse4;
        string Q;

        public RepondreQuestion(int cat, string JoueurCourant)
        {
            InitializeComponent();
            Joueur = JoueurCourant;
            Category = cat;
            if (Category == 1)
            {
                this.BackColor = Color.YellowGreen;
            }
            else if (Category == 2)
            {
                this.BackColor = Color.DarkOrange;
            }
            else if (Category == 3)
            {
                this.BackColor = Color.DodgerBlue;
            }
            else if (Category == 4)
            {
                this.BackColor = Color.Orchid;
            }

            AfficherQuestion();
            AfficherReponses();

        }

        private void AfficherQuestion()
        {
            OracleCommand oracmd = new OracleCommand("GESTIONINTELLICRACK", Connexion.oraconn);

            oracmd.CommandText = "GESTIONINTELLICRACK.Trouver_Question";
            oracmd.CommandType = CommandType.StoredProcedure;

            //Return
            OracleParameter oraReturn = new OracleParameter("retval", OracleDbType.Int32);
            oraReturn.Direction = ParameterDirection.ReturnValue;
            oracmd.Parameters.Add(oraReturn);

            // Categorie
            OracleParameter oraP_Categorie = new OracleParameter("P_CATEGORIE", OracleDbType.Char, 2);
            oraP_Categorie.Direction = ParameterDirection.Input;
            oraP_Categorie.Value = GetCodeCategorie(Category);
            oracmd.Parameters.Add(oraP_Categorie);

            oracmd.ExecuteNonQuery();

            Q = oracmd.Parameters["retval"].Value.ToString();

            LB_Question.Text = GetQuestion();
        }

        private void AfficherReponses()
        {
            OracleCommand oraliste = new OracleCommand("GESTIONINTELLICRACK", Connexion.oraconn);
            oraliste.CommandText = "GESTIONINTELLICRACK.Trouver_Reponses";
            oraliste.CommandType = CommandType.StoredProcedure;

            // Return Value
            OracleParameter OrapameResultat = new OracleParameter("Enr_Reponse", OracleDbType.RefCursor);
            OrapameResultat.Direction = ParameterDirection.ReturnValue;
            oraliste.Parameters.Add(OrapameResultat);

            // déclaration du paramètre en IN
            OracleParameter OrapamDesc = new OracleParameter("FNUMQ", OracleDbType.Char, 3);
            OrapamDesc.Value = Q;
            OrapamDesc.Direction = ParameterDirection.Input;
            oraliste.Parameters.Add(OrapamDesc);

            OracleDataReader Oraread = oraliste.ExecuteReader();

            for (int i = 0; i < 4; i++)
            {
                if (Oraread.Read())
                {
                    if (i == 0)
                        Reponse1 = Oraread.GetInt32(0);
                    else if (i == 1)
                        Reponse2 = Oraread.GetInt32(0);
                    else if (i == 2)
                        Reponse3 = Oraread.GetInt32(0);
                    else if (i == 3)
                        Reponse4 = Oraread.GetInt32(0);
                }
            }

            Random random = new Random();
            int r = random.Next(0, 8);
            if (r == 0)
            {
                TB_Reponse1.Text = GetReponseText(Reponse1);
                TB_Reponse2.Text = GetReponseText(Reponse2);
                TB_Reponse3.Text = GetReponseText(Reponse3);
                TB_Reponse4.Text = GetReponseText(Reponse4);
            }
            else if (r == 1)
            {
                TB_Reponse1.Text = GetReponseText(Reponse2);
                TB_Reponse2.Text = GetReponseText(Reponse1);
                TB_Reponse3.Text = GetReponseText(Reponse3);
                TB_Reponse4.Text = GetReponseText(Reponse4);
            }
            else if (r == 2)
            {
                TB_Reponse1.Text = GetReponseText(Reponse1);
                TB_Reponse2.Text = GetReponseText(Reponse2);
                TB_Reponse3.Text = GetReponseText(Reponse4);
                TB_Reponse4.Text = GetReponseText(Reponse3);
            }
            else if (r == 3)
            {
                TB_Reponse1.Text = GetReponseText(Reponse2);
                TB_Reponse2.Text = GetReponseText(Reponse3);
                TB_Reponse3.Text = GetReponseText(Reponse1);
                TB_Reponse4.Text = GetReponseText(Reponse4);
            }
            else if (r == 4)
            {
                TB_Reponse1.Text = GetReponseText(Reponse4);
                TB_Reponse2.Text = GetReponseText(Reponse3);
                TB_Reponse3.Text = GetReponseText(Reponse2);
                TB_Reponse4.Text = GetReponseText(Reponse1);
            }
            else if (r == 5)
            {
                TB_Reponse1.Text = GetReponseText(Reponse3);
                TB_Reponse2.Text = GetReponseText(Reponse4);
                TB_Reponse3.Text = GetReponseText(Reponse1);
                TB_Reponse4.Text = GetReponseText(Reponse2);
            }
            else if (r == 6)
            {
                TB_Reponse1.Text = GetReponseText(Reponse1);
                TB_Reponse2.Text = GetReponseText(Reponse4);
                TB_Reponse3.Text = GetReponseText(Reponse3);
                TB_Reponse4.Text = GetReponseText(Reponse2);
            }
            else if (r == 7)
            {
                TB_Reponse1.Text = GetReponseText(Reponse3);
                TB_Reponse2.Text = GetReponseText(Reponse1);
                TB_Reponse3.Text = GetReponseText(Reponse2);
                TB_Reponse4.Text = GetReponseText(Reponse4);
            }
        }

        private void ValiderReponse(string Reponse)
        {
            OracleCommand oraliste = new OracleCommand("GESTIONINTELLICRACK", Connexion.oraconn);
            oraliste.CommandText = "GESTIONINTELLICRACK.Valider_Reponse";
            oraliste.CommandType = CommandType.StoredProcedure;

            // Return Value
            OracleParameter OrapameResultat = new OracleParameter("Rep", OracleDbType.Char, 1);
            OrapameResultat.Direction = ParameterDirection.ReturnValue;
            oraliste.Parameters.Add(OrapameResultat);

            // déclaration du paramètre en IN
            OracleParameter OrapamDesc = new OracleParameter("FREPONSE", OracleDbType.Int32);
            OrapamDesc.Value = GetNumReponse(Reponse);
            OrapamDesc.Direction = ParameterDirection.Input;
            oraliste.Parameters.Add(OrapamDesc);

            oraliste.ExecuteNonQuery();

            if (oraliste.Parameters["Rep"].Value.ToString() == "Y")
            {
                MessageBox.Show("Bonne Réponse!");
                UpdateScore();
                this.Close();
            }
            else
            {
                MessageBox.Show("Mauvaise Réponse");
                this.Close();
            }
        }

        private void UpdateScore()
        {
            OracleCommand oraliste = new OracleCommand("GESTIONINTELLICRACK", Connexion.oraconn);
            oraliste.CommandText = "GESTIONINTELLICRACK.Update_Score";
            oraliste.CommandType = CommandType.StoredProcedure;

            // Paramètre de la catégorie
            OracleParameter OrapameResultat = new OracleParameter("FCATEGORIE", OracleDbType.Char, 2);
            OrapameResultat.Value = GetCodeCategorie(Category);
            OrapameResultat.Direction = ParameterDirection.Input;
            oraliste.Parameters.Add(OrapameResultat);

            // Paramètre du numero du match
            OracleParameter OraNumMatch = new OracleParameter("F_NumMatch", OracleDbType.Int32);
            OraNumMatch.Value = Jeu.NumMatch;
            OraNumMatch.Direction = ParameterDirection.Input;
            oraliste.Parameters.Add(OraNumMatch);

            // déclaration du paramètre en IN
            OracleParameter OrapamDesc = new OracleParameter("F_UserName", OracleDbType.Varchar2, 30);
            OrapamDesc.Value = Joueur;
            OrapamDesc.Direction = ParameterDirection.Input;
            oraliste.Parameters.Add(OrapamDesc);

            oraliste.ExecuteNonQuery();
        }

        //Click the textbox = ValiderReponse
        #region TB_Click
        private void TB_Reponse1_Click(object sender, EventArgs e)
        {
            ValiderReponse(TB_Reponse1.Text);
        }

        private void TB_Reponse2_Click(object sender, EventArgs e)
        {
            ValiderReponse(TB_Reponse2.Text);
        }

        private void TB_Reponse3_Click(object sender, EventArgs e)
        {
            ValiderReponse(TB_Reponse3.Text);
        }

        private void TB_Reponse4_Click(object sender, EventArgs e)
        {
            ValiderReponse(TB_Reponse4.Text);
        }
        #endregion

        //Région avec les fonctions pour get des valeurs en SQL
        #region GetSQL
        private string GetQuestion()
        {
            string Question = "";
            string SQLCode = "SELECT EnonceQuestion FROM Questions WHERE NumQuestion = " + Q;

            OracleCommand orcmd = new OracleCommand(SQLCode, Connexion.oraconn);
            orcmd.CommandType = CommandType.Text;
            OracleDataReader orareader = orcmd.ExecuteReader();

            if (orareader.Read())
            {
                Question = orareader.GetString(0);
            }

            return Question;
        }

        private int GetNumReponse(string Reponse)
        {
            int NumR = 0;

            string SQLCode = "SELECT NumReponse FROM Reponses WHERE Description = '" + Reponse + "'";

            OracleCommand orcmd = new OracleCommand(SQLCode, Connexion.oraconn);
            orcmd.CommandType = CommandType.Text;
            OracleDataReader orareader = orcmd.ExecuteReader();

            if (orareader.Read())
            {
                NumR = orareader.GetInt32(0);
            }

            return NumR;
        }

        private string GetReponseText(int NumRep)
        {
            string Rep = "";
            string SQLCode = "SELECT DESCRIPTION FROM REPONSES WHERE NUMREPONSE = " + NumRep;

            OracleCommand orcmd = new OracleCommand(SQLCode, Connexion.oraconn);
            orcmd.CommandType = CommandType.Text;
            OracleDataReader orareader = orcmd.ExecuteReader();

            if (orareader.Read())
            {
                Rep = orareader.GetString(0);
            }

            return Rep;
        }

        private object GetCodeCategorie(int Category)
        {
            if (Category == 1)
            {
                return "Sc";
            }
            else if (Category == 2)
            {
                return "Sp";
            }
            else if (Category == 3)
            {
                return "Jv";
            }
            else if (Category == 4)
            {
                return "Di";
            }
            else
                return "Sc";
        }

        #endregion

    }
}
