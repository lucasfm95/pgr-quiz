﻿using Dapper.Contrib.Extensions;
using Microsoft.Extensions.Configuration;
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
        protected IDbConnection Conn => new SqlConnection(_config.GetConnectionString("DefaultConnection"));

        public Repository(IConfiguration config)
        {
            _config = config;
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
    }
}