using Quiz.Domain.Entities;
using System.Collections.Generic;

namespace Quiz.Business.Interfaces
{
    public interface IScoreBusiness
    {
        List<Score> GetAll();
        List<Score> GetByCustomerId(int customerid);
    }
}
