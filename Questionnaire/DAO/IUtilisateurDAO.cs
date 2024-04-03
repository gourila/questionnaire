using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questionnaire.DAO
{
    internal interface IUtilisateurDAO
    {
        void AjouterUtilisater(Utilisateurs User);
        void SupprimerUtilisateur(Utilisateurs User);
        void ModifierUtilisateur(Utilisateurs user);
        Utilisateurs ChercherParEmail(string EMail);
        List<Utilisateurs>CherchertTout();
        List<Utilisateurs> ChercherParVille(string Ville);
        Utilisateurs ChercherParLoginMP(string login, string mp);

    }
}
