using Questionnaire.DAO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Fabrique
{
    public static IUtilisateurDAO CreerIutilisateurDAO(string choix) 
    {
        if (choix == "File") 
        {
            return new UtilisateurDAOFile();
        
        }
        else {  return null; }  
    }



}
















