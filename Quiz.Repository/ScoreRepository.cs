using Quiz.Domain.Entities;
using System.Collections.Generic;
using Quiz.Repository.Abstract;
using Quiz.Repository.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Dapper;

namespace Quiz.Repository
{
    public class ScoreRepository : Repository<Score>, IScoreRepository
    {
        public ScoreRepository(IConfiguration config, ILogger logger) : base(config, logger)
        {
        }

        public override List<Score> GetAll()
        {
            var query =
                "select CustomerName,BirthDate,SocialClass,CustomerScore from vwScore" +
                " order by 4 desc,1";
            var parameters = new DynamicParameters();

            return ExecuteQuery(query, parameters);
        }

        public List<Score> GetByCustomerId(int customerid)
        {
            var query =
                "select CustomerName,BirthDate,SocialClass,CustomerScore from vwScore" +
                " where customerid=@customerid";
            var parameters = new DynamicParameters();
            parameters.Add("@customerid", customerid);

            return ExecuteQuery(query, parameters);
        }
    }
}
