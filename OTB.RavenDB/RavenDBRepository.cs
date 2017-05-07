using Raven.Client.Document;
using System;
using System.Collections.Generic;
using System.Configuration;
using OTB.Common.Repository;
using OTB.Common.Repositories;
using OTB.Common.Repositories.Entities;
using System.Linq.Expressions;
using Raven.Client;

namespace OTB.RavenDB
{
    public class RavenDBRepository : IRepository
    {

        private string _ravenDBUrl;
        private IDocumentStore _documentStore;

        public RavenDBRepository(string ravenDBUrl = null)
        {
            _ravenDBUrl = ravenDBUrl;

            if (ravenDBUrl.IsNullOrEmpty())
            {
                if (ConfigurationManager.AppSettings["ravendburl"].IsNullOrEmpty())
                {
                    throw new Exception("The RavenDB URl in the configuration section is either missing or invalid.  Ensure the appsetting for 'ravendburl' is set with the correct path to the RavenDB document store.");
                }

                _ravenDBUrl = ConfigurationManager.AppSettings["ravendburl"]; 
            }
        }

        public virtual DBResult<TEntity> Delete<TEntity>(IEnumerable<TEntity> entities) where TEntity : IDBEntity
        {
            throw new NotImplementedException();
        }

        public virtual DBResult<TEntity> Delete<TEntity>(TEntity entity) where TEntity : IDBEntity
        {
            throw new NotImplementedException();
        }

        public virtual DBResult<TEntity> DeleteById<TEntity>(string id) where TEntity : IDBEntity
        {
            throw new NotImplementedException();
        }

        public virtual DBResult<TEntity> DeleteWhere<TEntity>(Expression<Func<TEntity, bool>> predicate) where TEntity : IDBEntity
        {
            throw new NotImplementedException();
        }

        public virtual DBResult<TEntity> FindAll<TEntity>() where TEntity : IDBEntity
        {
            throw new NotImplementedException();
        }

        public virtual DBResult<TEntity> FindAll<TEntity>(Expression<Func<TEntity, bool>> predicate) where TEntity : IDBEntity
        {
            throw new NotImplementedException();
        }

        public virtual DBResult<TEntity> FindById<TEntity>(string id) where TEntity : IDBEntity
        {
            throw new NotImplementedException();
        }

        public virtual DBResult<TEntity> Save<TEntity>(TEntity entity) where TEntity : IDBEntity
        {
            var result = new DBResult<TEntity>();

            try
            {
                using (var store = new DocumentStore()
                {
                    Url = _ravenDBUrl,
                    DefaultDatabase = "PTM"

                }.Initialize())
                {
                    using (var session = store.OpenSession())
                    {
                        session.Store(entity);
                        session.SaveChanges();
                        result = new DBResult<TEntity>(true, entity);
                    }
                }
            }
            catch (Exception ex)
            {
                result = new DBResult<TEntity>(ex);
            }

            return result;
        }

        public virtual DBResult<TEntity> Save<TEntity>(IEnumerable<TEntity> entities) where TEntity : IDBEntity
        {
            throw new NotImplementedException();
        }

        public virtual DBResult<TEntity> Update<TEntity>(IEnumerable<TEntity> entities) where TEntity : IDBEntity
        {
            throw new NotImplementedException();
        }

        public virtual DBResult<TEntity> Update<TEntity>(TEntity entity) where TEntity : IDBEntity
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
