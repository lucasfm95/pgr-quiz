using Quiz.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz.Services.Interfaces
{
    public interface IQuestionGroupServices
    {
        QuestionGroup Insert(QuestionGroup questionGroup);

        List<QuestionGroup> GetAll();
    }
}
