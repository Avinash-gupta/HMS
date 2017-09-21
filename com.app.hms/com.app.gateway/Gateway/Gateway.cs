using com.app.gateway.Contracts;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace com.app.gateway.Gateway
{
    public class Gateway<TContext, TEntity> : IGateway<TEntity> where TContext : DbContext
        where TEntity : class
    {
        protected readonly IUnitOfWork<TContext> _unitOfWork;

        protected IDbSet<TEntity> DbSet
        {
            get
            {
                return _unitOfWork.Set<TEntity>();
            }
        }

        public Gateway(IUnitOfWork<TContext> unitOfWork)
        {
            _unitOfWork = unitOfWork;

        }

        public virtual IQueryable<TEntity> GetAll()
        {
            return DbSet;
        }

        public async Task<TEntity> GetByIdAsync(object id)
        {
            return DbSet.Find(id);
        }

        public virtual IGateway<TEntity> Add(TEntity entity)
        {
            DbSet.Add(entity);
            return this;
        }

        public virtual IGateway<TEntity> Delete(object id)
        {
            var entity = DbSet.Find(id);
            var dbEntry = _unitOfWork.GetContext().Entry(entity);
            if (dbEntry.State == EntityState.Detached)
                DbSet.Attach(entity);
            DbSet.Remove(entity);
            return this;
        }

        public virtual IGateway<TEntity> Update(object newValues)
        {
            _unitOfWork.SetValues<TEntity>(newValues);
            return this;
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _unitOfWork.CommitAsync();
        }

    }
}
