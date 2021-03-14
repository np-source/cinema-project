using Cinema.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Cinema.Services
{
    public class MockRepository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        private List<Film> _filmsList;

        public MockRepository()
        {
            _filmsList = new List<Film>()
            {
                new Film() { Id = 0, Name = "Tor", Genre = Genre.Comedy },
                new Film() { Id = 1, Name = "Iron man", Genre = Genre.Drama },
                new Film() { Id = 2, Name = "Avatar", Genre = Genre.Drama },
                new Film() { Id = 3, Name = "Dodo", Genre = Genre.Comedy },
                new Film() { Id = 4, Name = "Devs", Genre = Genre.Horror }
            };

        }

        public IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = "")
        {
            return (IEnumerable<TEntity>)_filmsList;
        }

        public void Delete(TEntity entityToDelete)
        {
            throw new NotImplementedException();
        }

        public TEntity GetByID(object id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetWithRawSql(string query, params object[] parameters)
        {
            throw new NotImplementedException();
        }

        public void Insert(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity entityToUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
