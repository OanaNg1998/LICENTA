﻿
using JUSTMOVE.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JUSTMOVE.Repositories.GenericRepository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly ApplicationDbContext _context;
        protected readonly DbSet<T> _table;

        public GenericRepository(ApplicationDbContext context)
        {
            _context = context;
            _table = context.Set<T>();
        }

        public void Create(T entity)
        {
            _table.Add(entity);
            _context.SaveChanges();
        }

        public void CreateRange(List<T> entities)
        {
            _table.AddRange(entities);
            _context.SaveChanges();
        }

        public void Delete(T entity)
        {
            _table.Remove(entity);
            _context.SaveChanges();
        }

        public T FindById(string id)
        {
            return _table.Find(id);
        }

        public List<T> GetAll()
        {
            return _table.ToList();
        }

        public bool SaveChanges()
        {
            return _context.SaveChanges() > 0;
        }

        public void Update(T entity)
        {
            _table.Update(entity);
            _context.SaveChanges();
        }
    }

}
