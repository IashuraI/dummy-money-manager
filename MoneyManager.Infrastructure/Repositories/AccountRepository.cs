using MoneyManager.Core.Enities;
using MoneyManager.Core.Repositories.Account;
using MoneyManager.Infrastructure.Data;
using MoneyManager.Infrastructure.Repositories.Base;

namespace MoneyManager.Infrastructure.Repositories
{
    public class AccountRepository : RepositoryEF<AccountEntity, Guid>, IAccountRepository
    {
        public AccountRepository(MoneyManagerContext dummyBetContext) : base(dummyBetContext)
        {
        }
    }
}
