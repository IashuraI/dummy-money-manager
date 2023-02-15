namespace MoneyManager.Core.Repositories.Base;

public interface IRepository<TEntity, TKey> where TEntity : class
    where TKey : struct
{
    Task<IReadOnlyList<TEntity>> GetAllAsync();
    Task<TEntity?> GetByIdAsync(TKey id);
    Task<TEntity> AddAsync(TEntity tEntity);
    Task<TEntity?> UpdateAsync(TEntity tEntity, TKey id);
    Task DeleteAsync(TKey id);
}
