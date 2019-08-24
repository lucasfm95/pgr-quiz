using Quiz.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz.Services.Interfaces
{
    public interface ICustomerServices
    {
        Customer Insert(Customer customer);
    }
}
