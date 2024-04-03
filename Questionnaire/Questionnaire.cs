using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questionnaire
{
    internal class Questionnaire
    {
        public List<Question> nbQuestion = new List<Question>();
        public int ScoreFinal { get; set; }

        public Questionnaire(List<Question> nbquestion, int Scorefinal) 
        {
            nbQuestion = nbquestion;
            ScoreFinal = Scorefinal;
        }

        void RemplirQuestionnaire() 
        {
            
        }

        void AfficherQuestionnaire() 
        {
          List<Question> nbquestions = nbQuestion;
            foreach (Question question in nbquestions) 
            {
                question.ToString();            
            }
        }

        void CalculerResultats() 
        {
         
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
