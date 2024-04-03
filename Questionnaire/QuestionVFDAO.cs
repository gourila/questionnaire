using Questionnaire;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfceCommandePIzza
{
    internal class QuestionVFDAO
    {
        private string path = @"../../bd/questionVF.txt";
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
            string[] ligneFichier = File.ReadAllLines(path);
            List<Question> resultat = new List<Question>();
            foreach (string s in ligneFichier)
            {
                string[] tab = s.Split(';');
                Question question = new QuestionVF
                    (
                        tab[0], int.Parse(tab[1]), bool.Parse(tab[2])

                    ); resultat.Add(question);
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

