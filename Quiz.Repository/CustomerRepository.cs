using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Quiz.Domain;
using Quiz.Repository.Abstract;
using Quiz.Repository.Interfaces;

namespace Quiz.Repository
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public CustomerRepository(IConfiguration config, ILogger logger) : base(config, logger)
        {
        }
    }
}
