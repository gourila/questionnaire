
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //annuler
        private void button4_Click(object sender, EventArgs e)
        {

        }
        //Valider
        private void button3_Click(object sender, EventArgs e)
        {
           

        }

        private void ActionAnnuler(object sender, EventArgs e)
        {
            Text_login.Text = string.Empty;
        }

        private void Action_Connexion(object sender, EventArgs e)
        {
            //recuperrer les textboxs
            string login = Text_login.Text;
            string mp = txt_mp.Text;

            IUtilisateurDAO UserDao = Fabrique.CreerIutilisateurDAO("File");
            

            Utilisateurs users = UserDao.ChercherParLoginMP(login, mp);
            if (users != null)
            {
                new NouvelUtilisateur().Show();

            }
            else ActionAnnuler(sender, e);
        }
    }
}
