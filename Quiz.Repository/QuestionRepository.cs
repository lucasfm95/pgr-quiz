﻿using Microsoft.Extensions.Configuration;
using Quiz.Domain;
using Quiz.Repository.Abstract;
using Quiz.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz.Repository
{
    public class QuestionRepository : Repository<Question> , IQuestionRepository
    {
        public QuestionRepository(IConfiguration config) : base(config)
        {
        }
    }
}
