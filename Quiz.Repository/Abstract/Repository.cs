using Dapper;
using Dapper.Contrib.Extensions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Quiz.Domain.Entities.Abstract;
using Quiz.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Quiz.Repository.Abstract
{
    public class Repository<T> : IRepository<T> where T : Entity
    {
        private readonly IConfiguration _config;
        private readonly ILogger _logger;
        protected IDbConnection Conn => new SqlConnection(_config.GetConnectionString("DefaultConnection"));

        public Repository(IConfiguration config, ILogger logger)
        {
            _config = config;
            _logger = logger;
        }
        
        public virtual T Insert(T obj)
        {
            try
            {
                Conn.Insert(obj);
            }
            catch (Exception ex)
            {
                
            }
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

        public virtual List<T> ExecuteQuery(string query, DynamicParameters parameters = null)
        {
            try
            {
                if (parameters == null)
                    return Conn.Query<T>(query).ToList();

                return Conn.Query<T>(query, parameters).ToList();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                throw;
            }
            finally
            {
                if ((Conn != null) && (Conn.State != ConnectionState.Closed))
                {
                    Conn.Close();
                }
            }
        }
    }
}
