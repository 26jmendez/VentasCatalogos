using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly IUnitOfWork _unitOfWork;
        internal DbSet<TEntity> dbset;

        public Repository(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            dbset = _unitOfWork.Context.Set<TEntity>();
        }

        public TEntity Primero(Expression<Func<TEntity, bool>> expression)
        {
            return dbset.FirstOrDefault(expression);
        }

        public IEnumerable<TEntity> ObtenerTodos()
        {
            return dbset;
        }

        public IEnumerable<TEntity> ObtenerTodos(Expression<Func<TEntity, bool>> expression)
        {
            return dbset.Where(expression);
        }

        public void Agregar(TEntity entity)
        {
            dbset.Add(entity);
        }

        public void AgregarVarios(ICollection<TEntity> entities)
        {
            dbset.AddRange(entities);
        }

        public void Borrar(TEntity entity)
        {
            dbset.Remove(entity);
        }

        public void BorrarVarios(ICollection<TEntity> entities)
        {
            dbset.RemoveRange(entities);
        }

        public bool Existe(Expression<Func<TEntity, bool>> expression)
        {
            return dbset.Any(expression);
        }
    }
}
