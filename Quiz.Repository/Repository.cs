using Dapper.Contrib.Extensions;
using Microsoft.Extensions.Configuration;
using Quiz.Domain.Entities;
using Quiz.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Quiz.Repository
{
    public class Repository<T> : IRepository<T> where T : Entity
    {
        private readonly IConfiguration _config;
        private dynamic Conn => new SqlConnection(_config.GetConnectionString("DefaultConnection"));

        public Repository(IConfiguration config)
        {
            _config = config;
        }
        
        public virtual T Insert(T obj)
        {
            Conn.Insert(obj);
            return obj;
        }

        public virtual List<T> GetAll()
        {
            return Conn.GetAll<T>().ToList();
        }

        public virtual T GetById(int id)
        {
            return Conn.Get<T>(id);
        }

        public List<T> BulkInsert(List<T> list)
        {
            return Conn.BulkInsert(list);
        }
    }
}
