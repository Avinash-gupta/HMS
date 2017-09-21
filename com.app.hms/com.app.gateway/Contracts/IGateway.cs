using System.Linq;
using System.Threading.Tasks;

namespace com.app.gateway.Contracts
{
    public interface IGateway<TEntity> where TEntity : class
    {
        IGateway<TEntity> Add(TEntity entity);
        IGateway<TEntity> Delete(object id);
        IQueryable<TEntity> GetAll();
        Task<TEntity> GetByIdAsync(object id);
        IGateway<TEntity> Update(object newValues);
        Task<int> SaveChangesAsync();
    }
}
