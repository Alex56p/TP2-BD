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
        int Category;
        int Reponse1;
        int Reponse2;
        int Reponse3;
        int Reponse4;
        object Q;
        
        public RepondreQuestion(int cat)
        {
            InitializeComponent();
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
            OracleParameter oraReturn = new OracleParameter("retval", OracleDbType.Varchar2, 200);
            oraReturn.Direction = ParameterDirection.ReturnValue;
            oracmd.Parameters.Add(oraReturn);
            
            // Categorie
            OracleParameter oraP_Categorie = new OracleParameter("P_CATEGORIE", OracleDbType.Char, 2);
            oraP_Categorie.Direction = ParameterDirection.Input;
            oraP_Categorie.Value = GetCodeCategorie(Category);
            oracmd.Parameters.Add(oraP_Categorie);

            oracmd.ExecuteNonQuery();

            Q = oracmd.Parameters["retval"].Value;
            LB_Question.Text = Q.ToString();
        }

        private void AfficherReponses()
        {
            OracleCommand oraliste = new OracleCommand("GESTIONINTELLICRACK", Connexion.oraconn);
            oraliste.CommandText = "GESTIONINTELLICRACK.Trouver_Reponses";
            oraliste.CommandType = CommandType.StoredProcedure;

            // Return Value
            OracleParameter OrapameResultat = new OracleParameter("ENREMPLOYE", OracleDbType.RefCursor);
            OrapameResultat.Direction = ParameterDirection.ReturnValue;
            oraliste.Parameters.Add(OrapameResultat);

            // déclaration du paramètre en IN
            OracleParameter OrapamDesc = new OracleParameter("FNUMQ", OracleDbType.Char, 3);
            OrapamDesc.Value = GetNumQuestion();
            OrapamDesc.Direction = ParameterDirection.Input;
            oraliste.Parameters.Add(OrapamDesc);

            OracleDataReader Oraread = oraliste.ExecuteReader();

            for(int i = 0; i < 4; i++) 
            {
                if(Oraread.Read())
                {
                    if(i == 0)
                        Reponse1 = Oraread.GetInt32(0);
                    else if (i == 1)
                        Reponse2 = Oraread.GetInt32(0);
                    else if( i == 2)
                        Reponse3 = Oraread.GetInt32(0);
                    else if (i == 3)
                        Reponse4 = Oraread.GetInt32(0);
                }
            }

            TB_Reponse1.Text = GetReponseText(Reponse1);
            TB_Reponse2.Text = GetReponseText(Reponse2);
            TB_Reponse3.Text = GetReponseText(Reponse3);
            TB_Reponse4.Text = GetReponseText(Reponse4);
        }

        private int GetNumQuestion()
        {
            int numQ = 0;
            string SQLCode = "SELECT NumQuestion FROM Questions WHERE EnonceQuestion = '" + Q +"'";

            OracleCommand orcmd = new OracleCommand(SQLCode, Connexion.oraconn);
            orcmd.CommandType = CommandType.Text;
            OracleDataReader orareader = orcmd.ExecuteReader();

            if (orareader.Read())
            {
                numQ = orareader.GetInt32(0);
            }

            return numQ;
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

        private void TB_Reponse1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
