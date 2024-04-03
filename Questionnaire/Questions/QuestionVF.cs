
using Questionnaire;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questionnaire
{
    internal class QuestionVF : Question
    {
        internal bool RéponseCorrecte { get; set; }
        internal bool ReponseUtilisateur { get; set; }
        public QuestionVF(string enonce, int poids, bool reponseC, bool reponseUtilisateur) : base(enonce, poids)
        {
            RéponseCorrecte = reponseC;
            ReponseUtilisateur = reponseUtilisateur;

        }
        public QuestionVF(string enonce, int poids, bool reponseC) : base(enonce, poids)
        {
            RéponseCorrecte = reponseC;
            

        }

        public override double resultat()
        {
            throw new NotImplementedException();
        }
    }
}
