using System;

public class Money
{
    public decimal Amount { get; }
    public string Currency { get; }

    public Money(decimal amount, string currency)
    {
        Amount = amount;
        Currency = currency;
    }

    public static Money operator +(Money a, Money b)
    {
        if (a.Currency != b.Currency)
            throw new InvalidOperationException("Currency mismatch");

        return new Money(a.Amount + b.Amount, a.Currency);
    }

    public static bool operator ==(Money a, Money b)
    {
        return a.Amount == b.Amount &&
               a.Currency == b.Currency;
    }

    public static bool operator !=(Money a, Money b)
    {
        return !(a == b);
    }

    public static bool operator >(Money a, Money b)
    {
        if (a.Currency != b.Currency)
            throw new InvalidOperationException("Currency mismatch");

        return a.Amount > b.Amount;
    }

    public static bool operator <(Money a, Money b)
    {
        if (a.Currency != b.Currency)
            throw new InvalidOperationException("Currency mismatch");

        return a.Amount < b.Amount;
    }

    public override bool Equals(object obj)
    {
        if (obj is Money money)
            return this == money;

        return false;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Amount, Currency);
    }

    public override string ToString()
    {
        return $"{Amount} {Currency}";
    }
}