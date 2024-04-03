using Questionnaire;
using Questionnaire.DAO;
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
    public partial class ChercherUtilisateur : Form
    {
        public ChercherUtilisateur()
        {
            InitializeComponent();
        }

        private void ResultatRechercherUtilisateur_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ChercherUtilisateur_Load(object sender, EventArgs e)
        {
            List<Utilisateurs> users = new UtilisateurDAOFile().CherchertTout();
            RechercherUsers.DataSource = users;


        }
    }
}
