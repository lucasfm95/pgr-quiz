using System;
using System.Collections.Generic;
using System.Text;
using Quiz.Business.Interfaces;
using Quiz.Domain.Entities;
using Quiz.Services.Interfaces;

namespace Quiz.Services
{
    public class ScoreServices : IScoreServices
    {
        private readonly IScoreBusiness _scoreBusiness;

        public ScoreServices(IScoreBusiness scoreBusiness)
        {
            _scoreBusiness = scoreBusiness;
        }

        public List<Score> GetAll()
        {
            return _scoreBusiness.GetAll();
        }

        public List<Score> GetByCustomerId(int customerid)
        {
            return _scoreBusiness.GetByCustomerId(customerid);
        }
    }
}
