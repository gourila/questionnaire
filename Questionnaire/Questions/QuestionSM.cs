using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questionnaire 
{
    internal class QuestionSM : Question
    {
        public List<string> ReponseCorrecte { get; set; }

        public List<string> ChoixReponse { get; set; }

        public List<string> ReponseSaisie { get; set; }

        public QuestionSM(string enonce, int poids, List<string> reponseC, List<string> choixreponse) : base(enonce, poids)
        {
            ReponseCorrecte = reponseC;
            ChoixReponse = choixreponse;

        }




        public override double resultat()
        {
            //return 50; faire le calcul 
            int nb = 0;
            //on suppose que la réponse saisie est égal
            foreach (var item in ReponseSaisie)
            {
                if (ReponseCorrecte.Contains(item)) nb++;
            }
            return nb * 50;
        }


        public override string ToString()
        {
            return base.ToString() + ";" +
                string.Join(",", ReponseCorrecte) + ";" +
                string.Join(",", ChoixReponse);
        }
    }

}

