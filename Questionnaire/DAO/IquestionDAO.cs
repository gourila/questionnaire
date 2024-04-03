using Questionnaire;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IquestionDAO
{
    internal interface IquestionDAO
    {
        void AjouterQuestion(Question question);
        void SupprimerQuestion(Question question);
        void ModifierQuestion(Question question);
        Question ChercherQuestion(string enonce);

        List<Question> ChercherToutesQuestions();
    }
}
