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

            LB_Question.Text = oracmd.Parameters["retval"].Value.ToString() ;
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
    }
}
