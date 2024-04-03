using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questionnaire
{
    internal class Utilisateurs
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Login { get; set; }

        public string MotDePasse { get; set; }

        public string Email { get; set; }   
        public string Ville { get; set; }


        public Utilisateurs() 
        {
            Nom = string.Empty;
            Prenom = string.Empty;
            Login = string.Empty;
            MotDePasse = string.Empty;
            Email = string.Empty;
            Ville = string.Empty;
        
        }
        public Utilisateurs(string nom, string prenom, string login, string motdepasse, string email, string ville) 
        {
            Nom = nom;
            Prenom = prenom;
            Login = login;
            MotDePasse= motdepasse;
            Email = email;
            Ville = ville;
        
        }
        /// <summary>
        /// ((utilisateur)obj).Email == Email
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (!(obj is Utilisateurs)) return false;
            Utilisateurs utilisateurs = obj as Utilisateurs;
            return utilisateurs.Email == Email;
        }
        public override string ToString()
        {
            return Nom +";"+Prenom+";"+Login+";"+MotDePasse+";"+Email+";"+Ville+";";
        }

    }
}
