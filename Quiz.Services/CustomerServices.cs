﻿using Quiz.Domain;
using Quiz.Repository.Interfaces;
using Quiz.Services.Interfaces;
using System;

namespace Quiz.Services
{
    public class CustomerServices : ICustomerServices
    {
        public readonly ICustomerRepository _customerRepository;
        public CustomerServices(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }
        public Customer Insert(Customer customer)
        {
            return _customerRepository.Insert(customer);
        }
    }
}
