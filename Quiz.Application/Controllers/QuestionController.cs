using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Quiz.Domain;
using Quiz.Services.Interfaces;

namespace Quiz.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionController : Controller
    {
        private readonly IQuestionServices _questionservices;
        private readonly ILogger<QuestionController> _logger;

        public QuestionController(IQuestionServices questionservices, ILogger<QuestionController> logger)
        {
            _questionservices = questionservices;
            _logger = logger;
        }

        [HttpGet]
        public ActionResult<List<Question>> GetAll()
        {
            List<Question> result = null;
            try
            {
                result = _questionservices.GetAll();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
            }
            return result;

        }

        [HttpGet("{id}")]
        public ActionResult<Question> Get(int id)
        {
            Question result = null;
            try
            {
                result = _questionservices.GetById(id);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
            }

            return result;
        }
    }
}