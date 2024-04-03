using Questionnaire;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfceCommandePIzza
{
    internal class QuestionSMDAO
    {
        private string path = @"../../bd/questionSM.txt";
        /// <summary>
        /// Ajouter une question dans un dossier 
        /// </summary>
        /// <param name="question"></param>
        public void AjouterQuestion(Question question)
        {
            string contenu = question.ToString() + "\n";
            File.AppendAllText(path, contenu);
        }

        public Question ChercherQuestion(string enonce)
        {
            throw new NotImplementedException();
        }

        public List<Question> ChercherToutesQuestions()
        {
            string[] lignesFichier = File.ReadAllLines(path);
            List<Question> resultat = new List<Question>();
            foreach (string s in lignesFichier)
            {
                List<string> br = new List<string>();
                List<string> choix = new List<string>();
                string[] tab = s.Split(';');
                br.AddRange(tab[2].Split(','));
                choix.AddRange(tab[3].Split(','));
                Question question = new QuestionSM(
                        tab[0],     //enonce
                        int.Parse(tab[1]),     //Poids
                        br,     //Login
                        choix
                    );
                resultat.Add(question);
            }
            return resultat;
        }


        public void ModifierQuestion(Question question)
        {
            throw new NotImplementedException();
        }

        public void SupprimerQuestion(Question question)
        {
            throw new NotImplementedException();
        }
    }
}

