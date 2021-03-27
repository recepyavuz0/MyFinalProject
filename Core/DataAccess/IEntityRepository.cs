using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    //generic constraint
    //where : girilen T tipini kısıtlama
    //class : referans tip olabilir
    //IEntity : ya IEntity gönderebilirsin ya da IEntity'den türetilmiş nesne gönderebilirsin
    //new() : new'lenebilir olmalı
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);

        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T,bool>>filter);
    }
}
