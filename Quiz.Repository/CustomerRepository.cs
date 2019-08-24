using Microsoft.Extensions.Configuration;
using Quiz.Domain;
using Quiz.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz.Repository
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public CustomerRepository(IConfiguration config) : base(config)
        {
        }
    }
}
