using System;
using System.Data.Entity;
using System.Threading.Tasks;

namespace com.app.gateway.Contracts
{
    public interface IUnitOfWork<TContext> : IDisposable where TContext : DbContext
    {
        Task<int> CommitAsync();
        IDbSet<T> Set<T>() where T : class;
        void SetValues<T>(object newValues) where T : class;
        TContext GetContext();
    }
}
