using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Quiz.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quiz.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionGroupController : Controller
    {
        private readonly IQuestionGroupServices _clientservices;
        private readonly ILogger<QuestionGroupController> _logger;

        public QuestionGroupController(IQuestionGroupServices clientservices, ILogger<QuestionGroupController> _logger)
        {
            _clientservices = clientservices;
        }
    }
}
