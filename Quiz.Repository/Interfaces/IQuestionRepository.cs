using Quiz.Domain;
using Quiz.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz.Repository.Interfaces
{
    public interface IQuestionRepository : IRepository<Question>
    {
    }
}
