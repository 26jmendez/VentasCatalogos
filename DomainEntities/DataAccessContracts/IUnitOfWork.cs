using System;
using DomainEntities.DataAccessContracts;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public interface IUnitOfWork : IDisposable
    {
//        DbContext Context { get; }

        void Completar();
    }
}
