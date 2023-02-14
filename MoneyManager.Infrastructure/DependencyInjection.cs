using MoneyManager.Core.Repositories.Base;
using MoneyManager.Infrastructure.Data;
using MoneyManager.Infrastructure.Repositories;
using MoneyManager.Infrastructure.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MoneyManager.Core.Repositories.Account;

namespace MoneyManager.Infrastructure;

public static class DependencyInjection
{
    public static void AddInfrastructure(this IServiceCollection serviceCollection, IConfiguration configuration)
    {
        serviceCollection.AddDbContexts(configuration);
        serviceCollection.AddRepositories();
    }

    private static void AddDbContexts(this IServiceCollection serviceCollection, IConfiguration configuration)
    {
        serviceCollection.AddDbContext<MoneyManagerContext>(options => options.UseNpgsql(configuration.GetConnectionString("MoneyManagerDbConnection")));
    }

    private static void AddRepositories(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<IAccountRepository, AccountRepository>();

        serviceCollection.AddScoped(typeof(IRepository<,>), typeof(RepositoryEF<,>));
    }
}

