using System;
using System.Collections.Generic;
using System.Text;
using Quiz.Business.Interfaces;
using Quiz.Domain.Entities;
using Quiz.Repository.Interfaces;

namespace Quiz.Business
{
    public class ScoreBusiness : IScoreBusiness
    {
        private readonly IScoreRepository _scoreRepository;

        public ScoreBusiness(IScoreRepository scoreRepository)
        {
            _scoreRepository = scoreRepository;
        }

        public List<Score> GetAll()
        {
            return _scoreRepository.GetAll();
        }

        public List<Score> GetByCustomerId(int customerid)
        {
            return _scoreRepository.GetByCustomerId(customerid);
        }
    }
}
