using System.ComponentModel.DataAnnotations;

namespace MoneyManager.Core.Enities;

public class AccountEntity
{
    [Key]
    public Guid AccountId { get; set; }

    public string Name { get; set; } = string.Empty!;

    public decimal Balance { get; set; }
}
