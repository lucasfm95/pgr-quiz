using Quiz.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz.Services.Interfaces
{
    public interface IScoreServices
    {
        List<Score> GetAll();
        List<Score> GetByCustomerId(int customerid);
    }
}
