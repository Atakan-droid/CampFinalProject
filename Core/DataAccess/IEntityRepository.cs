using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Core.DataAccess
{
    //generic constraint kısıt yani
    //class referans tip olabilir,
    //IEntities implement eden nesnelerden biri olabilir. 
    //new(): new'lenebilir olmalı.
   public interface IEntityRepository<T> where T:class,IEntities,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}
