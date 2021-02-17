﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JUSTMOVE.Repositories.GenericRepository
{
        public interface IGenericRepository<T> where T : class
        {
            List<T> GetAll();
            void Create(T entity);
            void Update(T entity);
            void Delete(T entity);
            void CreateRange(List<T> entities);
            T FindById(string id);
            bool SaveChanges();
        }
    
}
