using InterfceCommandePIzza;
using Questionnaire;
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
    public partial class NouvelUtilisateur : Form
    {
        public NouvelUtilisateur()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CenterPanel.Controls.Clear();
            CenterPanel.Controls.Add(new AjouterUtilisateur());

        }

        private void supprimerUtilisaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CenterPanel.Controls.Clear();
            CenterPanel.Controls.Add(new SupprimerUtilisateur());
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CenterPanel.Controls.Clear();

        }

        private void qToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void chercherUtilisateurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ChercherUtilisateur().Show();
        }

        private void NouvelUtilisateur_Load(object sender, EventArgs e)
        {

        }
    }
}
