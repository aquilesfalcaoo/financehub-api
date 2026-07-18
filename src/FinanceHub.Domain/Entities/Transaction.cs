using FinanceHub.Domain.Enums;

namespace FinanceHub.Domain.Entities;

public class Transaction
{
    public Guid Id { get; private set; }

    public Guid UserId { get; private set; }

    public Guid CategoryId { get; private set; }

    public Guid AccountId { get; private set; }

    public string Description { get; private set; } = string.Empty;

    public decimal Amount { get; private set; }

    public TransactionType Type { get; private set; }

    public TransactionStatus Status { get; private set; }

    public DateOnly TransactionDate { get; private set; }

    public DateTime CreatedAt { get; private set; }

    public DateTime? UpdatedAt { get; private set; }

    public User User { get; set; } = null!;
}