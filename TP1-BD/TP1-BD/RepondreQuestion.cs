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
    public partial class RepondreQuestion : Form
    {
        public RepondreQuestion(int cat)
        {
            InitializeComponent();

            if(cat == 1)
            {
                this.BackColor = Color.YellowGreen;
            } 
            else if (cat == 2)
            {
                this.BackColor = Color.DarkOrange;
            }
            else if (cat == 3)
            {
                this.BackColor = Color.DodgerBlue;
            }
            else if (cat == 4)
            {
                this.BackColor = Color.Orchid;
            }
            
        }

        private void AfficherQuestion()
        {

        }
    }
}
