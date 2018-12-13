using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess
{
    public interface IRepository<TEntity>
    {
        TEntity Primero(Expression<Func<TEntity, bool>> expression);

        IEnumerable<TEntity> ObtenerTodos();

        IEnumerable<TEntity> ObtenerTodos(Expression<Func<TEntity, bool>> expression);

        void Agregar(TEntity entity);

        void AgregarVarios(ICollection<TEntity> entities);

        void Borrar(TEntity entity);

        void BorrarVarios(ICollection<TEntity> entities);

        bool Existe(Expression<Func<TEntity, bool>> expression);
    }
}
