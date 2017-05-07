using OTB.Common.Repositories;
using OTB.Common.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace OTB.Common.Repository
{
    public interface IRepository : IDisposable
    {
        DBResult<TEntity> Save<TEntity>(TEntity entity) where TEntity : IDBEntity;

        DBResult<TEntity> Save<TEntity>(IEnumerable<TEntity> entities) where TEntity : IDBEntity;

        DBResult<TEntity> Update<TEntity>(TEntity entity) where TEntity : IDBEntity;

        DBResult<TEntity> Update<TEntity>(IEnumerable<TEntity> entities) where TEntity : IDBEntity;
        
        DBResult<TEntity> FindById<TEntity>(string id) where TEntity : IDBEntity;

        DBResult<TEntity> FindAll<TEntity>(Expression<Func<TEntity, bool>> predicate) where TEntity : IDBEntity;

        DBResult<TEntity> FindAll<TEntity>() where TEntity : IDBEntity;
        
        DBResult<TEntity> Delete<TEntity>(TEntity entity) where TEntity : IDBEntity;

        DBResult<TEntity> Delete<TEntity>(IEnumerable<TEntity> entities) where TEntity : IDBEntity;

        DBResult<TEntity> DeleteById<TEntity>(string id) where TEntity : IDBEntity;

        DBResult<TEntity> DeleteWhere<TEntity>(Expression<Func<TEntity, bool>> predicate) where TEntity : IDBEntity;
        
    }
}
