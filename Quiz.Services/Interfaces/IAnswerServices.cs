using Quiz.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz.Services.Interfaces
{
    public interface IAnswerServices
    {
        List<Answer> GetAll(int questionId );
        Answer GetById(int questionId, int id );
    }
}
