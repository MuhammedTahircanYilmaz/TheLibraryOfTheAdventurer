﻿using Core.Entities;
using System.Linq.Expressions;

namespace Core.Repository.Abstract;

public interface IRepository<TEntity, TId> where TEntity : Entity<TId>, new()
{
    TEntity Add(TEntity entity);
    TEntity Update(TEntity entity);
    TEntity Delete(TEntity entity);

    List<TEntity> GetAll(Expression<Func<TEntity,bool>>? filter = null);
    TEntity? GetById(TId id);
}
