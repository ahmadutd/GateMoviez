using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace GateMoviez.Data.Interface
{
    public interface IRepository<TEntity> where TEntity:class
    {
        //For Fetching Data
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> Find(Expression<Func<TEntity,bool>> expression);
        TEntity Get(Expression<Func<TEntity, bool>> expression);


        //For Handling Data
        void Add(TEntity entity);
        void AddRange(List<TEntity> entities);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        void DeleteRange(List<TEntity> entities);

    }
    
}
