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
    public class CustomerController : Controller
    {
        private readonly ICustomerServices _clientservices;
        private readonly ILogger<CustomerController> _logger;

        public CustomerController(ICustomerServices clientservices, ILogger<CustomerController> _logger)
        {
            _clientservices = clientservices;
        }

        [HttpPost]
        public ActionResult<Customer> Post(Customer customer)
        {
            Customer result;
            try
            {
                result = _clientservices.Insert(customer);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
            }
            return customer;
        }
    }
}