using DomainDrivenDesign.Abstractions.ValueObjects;

namespace DomainDrivenDesign.ValueObjects;

public record CountryCode
{
    public CountryCode(int value)
    {
        if (value < 0)
        {
            throw new ArgumentException("Value can not be negative.", nameof(value));
        }
        Value = value;
    }

    public int Value { get; protected set; }
}
