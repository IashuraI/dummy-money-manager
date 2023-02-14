using Microsoft.AspNetCore.Mvc;
using MoneyManager.Core.Enities;
using MoneyManager.Core.Repositories.Account;

namespace MoneyManager.WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class AccountController : ControllerBase
{

    private readonly IAccountRepository _accountRepository;

    public AccountController(IAccountRepository accountRepository)
    {
        _accountRepository = accountRepository;
    }

    [HttpGet]
    public async Task<IReadOnlyList<AccountEntity>> Get()
    {
        return await _accountRepository.GetAllAsync();
    }
}
