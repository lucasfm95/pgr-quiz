using Quiz.Domain.Entities;
using System.Collections.Generic;

namespace Quiz.Repository.Interfaces
{
    public interface IScoreRepository : IRepository<Score>
    {
        List<Score> GetByCustomerId(int customerid);
    }
}
