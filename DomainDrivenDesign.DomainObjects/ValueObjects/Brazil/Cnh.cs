using DomainDrivenDesign.Abstractions.Extensions;
using DomainDrivenDesign.DomainObjects.Entities;

namespace DomainDrivenDesign.DomainObjects.ValueObjects.Brazil;

public enum CnhType
{
    A = 1,
    B = 2,
    C = 4,
    D = 8,
    E = 16,
}

public record Cnh
{
    public Cnh(
        CnhType type,
        CnhNumber number,
        DateOnly firstExpiration,
        DateOnly expiration,
        DateOnly issuedAt,
        IssuingAuthority issuingAuthority)
    {
        Type = type;
        Number = number.Guard(new ArgumentNullException(nameof(number)));
        FirstExpiration = firstExpiration;
        Expiration = expiration;
        IssuedAt = issuedAt;
        IssuingAuthority = issuingAuthority.Guard(new ArgumentNullException(nameof(issuedAt)));
    }

    public CnhType Type { get; protected set; }
    public CnhNumber Number { get; protected set; }
    public DateOnly FirstExpiration { get; protected set; }
    public DateOnly Expiration { get; protected set; }
    public DateOnly IssuedAt { get; protected set; }
    public IssuingAuthority IssuingAuthority { get; protected set; }

    public void RenewFromPerson(AbstractPerson person)
    {
        var dateOfBirth = person.DateOfBirth.Guard(new ArgumentNullException(nameof(person.DateOfBirth)));
        RenewFromDateOfBirth(dateOfBirth);
    }

    public void RenewFromDateOfBirth(DateOfBirth date)
    {
        var age = date.GetAge();
        int durationYears = 0;

        if (age < 50)
        {
            durationYears = 10;
        }
        else if (age >= 50 && age < 70)
        {
            durationYears = 5;
        }
        else if (age >= 70)
        {
            durationYears = 3;
        }

        var expiration = DateOnly.FromDateTime(DateTime.UtcNow.AddYears(durationYears));
        Renew(expiration);
    }

    public void Renew(DateOnly expiration)
    {
        var today = DateOnly.FromDateTime(DateTime.UtcNow);

        if (expiration <= today)
        {
            throw new ArgumentException($"Expiration must be later than today. Value was: {expiration}.", nameof(expiration));
        }

        Expiration = expiration;
    }
}
