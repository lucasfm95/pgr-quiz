using System;
using System.Collections.Generic;
using System.Text;
using Quiz.Domain;
using Quiz.Repository.Interfaces;

namespace Quiz.Services.Interfaces
{
    public class QuestionGroupServices : IQuestionGroupServices
    {
        public readonly IQuestionRepository _questionRepository;

        public QuestionGroupServices(IQuestionRepository customerRepository)
        {
            _questionRepository = customerRepository;
        }

        public List<QuestionGroup> GetAll()
        {
            throw new NotImplementedException();
        }

        public QuestionGroup Insert(QuestionGroup questionGroup)
        {
            throw new NotImplementedException();
        }
    }
}
