using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Quiz.Business.Interfaces;
using Quiz.Domain;
using Quiz.Domain.Entities;
using Quiz.Services.Interfaces;

namespace Quiz.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScoreController : ControllerBase
    {

        private readonly IScoreServices _scoreservices;

        public ScoreController(IScoreServices scoreservices)
        {
            _scoreservices = scoreservices;
        }

        [HttpGet]
        public List<Score> GetAll()
        {
            return _scoreservices.GetAll();
        }

        [HttpGet("Customer/{customerid}")]
        public List<Score> GetByCustomerId(int customerid)
        {
            return _scoreservices.GetByCustomerId(customerid);
        }
    }
}