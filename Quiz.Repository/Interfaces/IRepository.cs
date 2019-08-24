using Quiz.Domain.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz.Repository.Interfaces
{
    public interface IRepository<T> where T : Entity
    {
        T Insert(T obj);
        List<T> GetAll();
        T GetById(int id);

    }
}
