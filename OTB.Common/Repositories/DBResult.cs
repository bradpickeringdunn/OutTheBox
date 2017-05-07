using OTB.Common.Repositories.Entities;
using System;
using System.Collections.Generic;

namespace OTB.Common.Repositories
{
    public class DBResult<TEntity> where TEntity : IDBEntity
    {
        public bool InError { get; set; }

        public Exception Exception { get; private set; }

        public IEnumerable<TEntity> Entities { get; private set; }

        public DBResult()
        {
            InitializeClass();
        }

        public DBResult(bool inError, TEntity entity)
        {
            InitializeClass();
            Entities = new List<TEntity>() { entity };
            InError = inError;
        }

        public DBResult(bool inError, IEnumerable<TEntity> entities)
        {
            InitializeClass();
            Entities = entities;
            InError = inError;
        }

        public DBResult(Exception exception)
        {
            InitializeClass();
            this.Exception = exception;
        }

        public DBResult(bool inError)
        {
            InitializeClass();
            InError = inError;
        }

        private void InitializeClass()
        {
            InError = true;
            Entities = new List<TEntity>();
        }
        
    }
}

    

