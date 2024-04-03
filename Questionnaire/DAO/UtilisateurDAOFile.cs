using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Questionnaire.DAO
{
    internal class UtilisateurDAOFile : IUtilisateurDAO
    {
        private string path = "../../BD/Fichier_Utilisateurs.ts";


        public void AjouterUtilisater(Utilisateurs User)
        {


           string cont = User.ToString() +"\n";
                File.AppendAllText(path, cont);

        }

        public Utilisateurs ChercherParEmail(string EMail)
        {
           return CherchertTout().Find(user => user.Email == EMail);                  
        }

        public Utilisateurs ChercherParLoginMP(string login, string mp)
        {
            return CherchertTout().Find(user => user.Login == login && user.MotDePasse == mp);
        }

        public List<Utilisateurs> ChercherParVille(string Ville)
        {
            return CherchertTout().FindAll(user => user.Ville == Ville);
        }

        public List<Utilisateurs> CherchertTout()
        {
            string[] Lignefichiers = File.ReadAllLines(path);
           List<Utilisateurs> resultat = new List<Utilisateurs>();
            foreach (string s in Lignefichiers) 
            {
                string[] tableDeUtlisateur = s.Split(';');
                Utilisateurs utilisateurs = new Utilisateurs(
                        tableDeUtlisateur[0],
                        tableDeUtlisateur[1],
                        tableDeUtlisateur[2],
                        tableDeUtlisateur[3],
                        tableDeUtlisateur[4],
                        tableDeUtlisateur[5]                           
                    );
                resultat.Add( utilisateurs );            
            }
            return resultat;
        }

        public void ModifierUtilisateur(Utilisateurs user)
        {
            SupprimerUtilisateur(user);
            AjouterUtilisater(user);
        }

        public void SupprimerUtilisateur(Utilisateurs User)
        {
            // recupère la liste des users
            List<Utilisateurs> AllUsers = CherchertTout();
            //je supprimer le user
            AllUsers.Remove(User);

            //je vide le fichier 
            File.WriteAllText(path,"");

            //je réinsère les users
            foreach (var u in AllUsers) { AjouterUtilisater(u); }
        }
    }
}
