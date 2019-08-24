﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Quiz.Domain;
using Quiz.Services.Interfaces;

namespace Quiz.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : Controller
    {
        private readonly ICustomerServices _clientservices;

        public CustomerController(ICustomerServices clientservices)
        {
            _clientservices = clientservices;
        }
        public ActionResult<Customer> Post(Customer customer)
        {
            return _clientservices.Insert(customer);
        }
    }
}