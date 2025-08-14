using DomainDrivenDesign.Abstractions.Attributes;
using DomainDrivenDesign.Abstractions.ValueObjects;

namespace DomainDrivenDesign.ValueObjects;

[StringValidation(MinLength = MIN_LENGTH, MaxLength = MAX_LENGTH)]
public record PersonName : ValidatableStringValue
{
    public const int MIN_LENGTH = 2;
    public const int MAX_LENGTH = 120;
    public PersonName(string value) : base(value)
    {
    }

    public string GetFirstName()
    {
        return Value.Split(' ').FirstOrDefault() ?? string.Empty;
    }

    public string GetLastName()
    {
        return Value.Split(' ').LastOrDefault() ?? string.Empty;
    }

    public string GetInitials()
    {
        var parts = Value.ToUpper().Split(' ');
        var first = parts.FirstOrDefault()?.FirstOrDefault() ?? '?';
        var last = parts.LastOrDefault()?.FirstOrDefault() ?? '?';

        return string.Concat(first, last);
    }
}
