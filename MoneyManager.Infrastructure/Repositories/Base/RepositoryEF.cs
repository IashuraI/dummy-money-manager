using MoneyManager.Core.Repositories.Base;
using MoneyManager.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace MoneyManager.Infrastructure.Repositories.Base
{
    public class RepositoryEF<TEntity, TKey> : IRepository<TEntity, TKey> where TEntity : class
        where TKey : struct
    {
        protected readonly MoneyManagerContext _moneyManagerContext;
        public RepositoryEF(MoneyManagerContext dummyBetContext)
        {
            _moneyManagerContext = dummyBetContext;
        }

        public async Task<IReadOnlyList<TEntity>> GetAllAsync()
        {
            return await _moneyManagerContext.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity?> GetByIdAsync(TKey id)
        {
            return await _moneyManagerContext.Set<TEntity>().FindAsync(id);
        }

        public async Task<TEntity> AddAsync(TEntity tEntity)
        {
            await _moneyManagerContext.Set<TEntity>().AddAsync(tEntity);
            await _moneyManagerContext.SaveChangesAsync();
            return tEntity;
        }

        public Task<TEntity?> UpdateAsync(TEntity tEntity, TKey id)
        {
            _moneyManagerContext.Set<TEntity>().Update(tEntity);

            _moneyManagerContext.SaveChanges();

            return GetByIdAsync(id);
        }

        public async Task DeleteAsync(TKey id)
        {
            TEntity? tEntity = await _moneyManagerContext.Set<TEntity>().FindAsync(id);

            if (tEntity != null)
            {
                _moneyManagerContext.Set<TEntity>().Remove(tEntity);
                await _moneyManagerContext.SaveChangesAsync();
            }
        }
    }
}
