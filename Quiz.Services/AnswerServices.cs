using Quiz.Business.Interfaces;
using Quiz.Domain.Entities;
using Quiz.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz.Services
{
    public class AnswerServices : IAnswerServices
    {
        private readonly IAnswerBusiness _answerBusiness;
        public AnswerServices( IAnswerBusiness answerBusiness )
        {
            _answerBusiness = answerBusiness;
        }

        public List<Answer> GetAll( int questionId )
        {
            return _answerBusiness.GetAll( questionId );
        }

        public Answer GetById( int questionId, int id )
        {
            return _answerBusiness.Get( questionId, id );
        }
    }
}
