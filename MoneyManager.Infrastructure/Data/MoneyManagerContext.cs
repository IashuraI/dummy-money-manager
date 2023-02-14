using Microsoft.EntityFrameworkCore;
using MoneyManager.Core.Enities;

namespace MoneyManager.Infrastructure.Data;

public class MoneyManagerContext : DbContext
{
    public MoneyManagerContext(DbContextOptions<MoneyManagerContext> dbContextOptions) : base(dbContextOptions) { }

    public DbSet<AccountEntity> Accounts { get; set; } = null!;
}

