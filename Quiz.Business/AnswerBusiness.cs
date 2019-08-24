using Quiz.Business.Interfaces;
using Quiz.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz.Business
{
    public class AnswerBusiness : IAnswerBusiness
    {
        public Answer Get( int questionId, int id )
        {
            throw new NotImplementedException( );
        }

        public List<Answer> GetAll( int questionId )
        {
            throw new NotImplementedException( );
        }
    }
}
