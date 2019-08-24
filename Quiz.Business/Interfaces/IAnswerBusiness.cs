using Quiz.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz.Business.Interfaces
{
    public interface IAnswerBusiness
    {
        List<Answer> GetAll( int questionId );
        Answer Get( int questionId, int id );
    }
}
