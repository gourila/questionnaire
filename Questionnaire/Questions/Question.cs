using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questionnaire
{
    internal abstract class Question
    {
        public string Enonce { get; set; }
        public int Poids { get; set; }

        public Question(string enonce, int poids)
        {
            Enonce = enonce;
            Poids = poids;
        }

        public override bool Equals(object obj)
        {
            return obj is Question question &&
                   Enonce == question.Enonce;
        }
        public abstract int resultat();

        public override int GetHashCode()
        {
            return -66272425 + EqualityComparer<string>.Default.GetHashCode(Enonce);
        }  // code?

        public override string ToString()
        {
            return "Énoncé : " + Enonce + "Poids :" + Poids;
        }





    }
}

