using Microsoft.Extensions.Configuration;
using Quiz.Domain;
using Quiz.Repository.Abstract;
using Quiz.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Logging;

namespace Quiz.Repository
{
    public class QuestionGroupRepository : Repository<QuestionGroup> , IQuestionGroupRepository
    {
        public QuestionGroupRepository(IConfiguration config, ILogger logger) : base(config, logger)
        {
        }
    }
}
