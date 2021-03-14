using Cinema.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Cinema.Services
{
    public class MockBaseRepository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        public List<TEntity> _entitiesList;

        public IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = "")
        {
            return _entitiesList;
        }

        public void Delete(TEntity entityToDelete)
        {
            _entitiesList.Remove(entityToDelete);
        }

        public TEntity GetByID(int id)
        {
            return _entitiesList.FirstOrDefault(x => x.Id == id);
        }

        public void Insert(TEntity entity)
        {
            _entitiesList.Add(entity);
        }

        public void Update(TEntity entityToUpdate)
        {
            var oldFilm = _entitiesList.FirstOrDefault(x => x.Id == entityToUpdate.Id);
            oldFilm = entityToUpdate;
        }

        public IEnumerable<TEntity> GetWithRawSql(string query, params object[] parameters)
        {
            throw new NotImplementedException();
        }
    }
}
