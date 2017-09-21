using com.app.gateway.Contracts;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Threading.Tasks;

namespace com.app.gateway.Gateway
{
    public class UnitOfWork<TContext> : IUnitOfWork<TContext>
         where TContext : DbContext, new()
    {
        private readonly TContext _context;

        public UnitOfWork()
        {
            _context = new TContext();
        }

        public virtual TContext GetContext()
        {
            return _context;
        }

        public virtual IDbSet<T> Set<T>() where T : class
        {
            return _context.Set<T>();
        }

        public virtual void SetValues<T>(object values) where T : class
        {
            var newValues = new[] { (T)values };
            Set<T>().AddOrUpdate(newValues);
        }

        public virtual async Task<int> CommitAsync()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
