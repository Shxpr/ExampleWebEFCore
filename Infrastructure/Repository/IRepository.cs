﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public interface IRepository<T> where T : class
    {
        T Get(int id);
        IList<T> GetAll();
        void Add(T entity);
        void Update(T entity);
        void Delete(int id);
    }
}
