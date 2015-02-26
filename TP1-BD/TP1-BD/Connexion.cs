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
        public OracleConnection oraconn = new OracleConnection();

        public Connexion()
        {
            InitializeComponent();
            Login();
        }

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

        private void BTN_Inscription_Click(object sender, EventArgs e)
        {
            Inscription inscription = new Inscription();
            inscription.ShowDialog();
        }
    }
}
