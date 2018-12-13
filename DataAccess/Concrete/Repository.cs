using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly DbContext Context;

        public Repository(DbContext context)
        {
            Context = context;
        }

        public TEntity Primero(Expression<Func<TEntity, bool>> expression)
        {
            return Context.Set<TEntity>().FirstOrDefault(expression);
        }

        public IEnumerable<TEntity> ObtenerTodos()
        {
            return Context.Set<TEntity>();
        }

        public IEnumerable<TEntity> ObtenerTodos(Expression<Func<TEntity, bool>> expression)
        {
            return Context.Set<TEntity>().Where(expression);
        }

        public void Agregar(TEntity entity)
        {
            Context.Set<TEntity>().Add(entity);
        }

        public void AgregarVarios(ICollection<TEntity> entities)
        {
            Context.Set<TEntity>().AddRange(entities);
        }

        public void Borrar(TEntity entity)
        {
            Context.Set<TEntity>().Remove(entity);
        }

        public void BorrarVarios(ICollection<TEntity> entities)
        {
            Context.Set<TEntity>().RemoveRange(entities);
        }

        public bool Existe(Expression<Func<TEntity, bool>> expression)
        {
            return Context.Set<TEntity>().Any(expression);
        }
    }
}
