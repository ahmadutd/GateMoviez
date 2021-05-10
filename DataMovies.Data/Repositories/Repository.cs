using GateMoviez.Data.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace GateMoviez.Data.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly GateMoviezDbContext _context;
        private DbSet<TEntity> _entity;

        public Repository(GateMoviezDbContext context)
        {
            _context = context;
            _entity= _context.Set<TEntity>();
        }


        public IEnumerable<TEntity> GetAll()
        {
            return _entity.ToList();
            
        }
        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> expression)
        {
            return _entity.Where(expression);
        }

        public TEntity Get(Expression<Func<TEntity, bool>> expression)
        {
            return _entity.FirstOrDefault(expression);
        }


        public void Add(TEntity entity)
        {
            _entity.Add(entity);
             
        }
        public void AddRange(List<TEntity> entities)
        {
            _entity.AddRange(entities);
        }
        public void Update(TEntity entity)
        {
            _entity.Update(entity);
             
        }
        public void Delete(TEntity entity)
        {
            _entity.Remove(entity);
            
        }

        
    }
}
