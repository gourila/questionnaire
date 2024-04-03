using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Questionnaire
{
    public partial class SupprimerUtilisateur : Form
    {
        public SupprimerUtilisateur()
        {
            InitializeComponent();
        }

        private void CheckBox_Supprimer_CheckedChanged(object sender, EventArgs e)
        {
            if ( CheckBox_Supprimer.Checked ) 
            {
                BTN_Supprimer.Visible = true;
            }
            else {  BTN_Supprimer.Visible = false;}
        }
    }
}
