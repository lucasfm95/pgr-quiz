using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Quiz.Domain.Entities;
using Quiz.Services.Interfaces;

namespace Quiz.Application.Controllers
{
    [Route( "api/Question/{questionId}/[controller]" )]
    [ApiController]
    public class AnswerController : ControllerBase
    {
        private readonly ILogger<AnswerController> _logger;
        private readonly IAnswerServices _answerServices;
        public AnswerController( ILogger<AnswerController> logger, IAnswerServices answerServices)
        {
            _logger = logger;
            _answerServices = answerServices;
        }

        [HttpGet]
        [ProducesResponseType( typeof( List<Answer> ), ( int )HttpStatusCode.OK )]
        public IActionResult Get( [FromRoute]int questionId )
        {
            IActionResult result;
            try
            {
                List<Answer> answers = _answerServices.GetAll( questionId );

                result = Ok( answers );
            }
            catch ( Exception ex)
            {
                _logger.LogError( ex, ex.Message );
                result = BadRequest( );
            }

            return result;
        }

        [HttpGet("{id}")]
        [ProducesResponseType( typeof( Answer ), ( int )HttpStatusCode.OK )]
        public IActionResult GetById([FromRoute]int questionId, int id )
        {
            IActionResult result;
            try
            {
                Answer answer = _answerServices.GetById( questionId, id);

                if ( answer == null )
                {
                    result = Ok( answer );
                }
                else
                {
                    result = NoContent( );
                }
            }
            catch ( Exception ex)
            {

                _logger.LogError( ex, ex.Message );
                result = BadRequest( );
            }

            return result;
        }

    }
}