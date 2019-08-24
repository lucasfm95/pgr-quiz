using Quiz.Domain;
using Quiz.Repository.Interfaces;
using Quiz.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz.Services
{
    public class QuestionServices : IQuestionServices
    {
        public readonly IQuestionRepository _questionRepository;
        public QuestionServices(IQuestionRepository customerRepository)
        {
            _questionRepository = customerRepository;
        }

        public List<Question> GetAll()
        {
            return _questionRepository.GetAll();
        }

        public Question GetById(int id)
        {
            return _questionRepository.GetById(id);
        }
    }
}
