using MoneyManager.Core.Enities;
using MoneyManager.Core.Repositories.Base;

namespace MoneyManager.Core.Repositories.Account
{
    public interface IAccountRepository : IRepository<AccountEntity, Guid>
    {
    }
}
