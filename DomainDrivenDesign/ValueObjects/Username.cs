using DomainDrivenDesign.Abstractions.Attributes;
using DomainDrivenDesign.Abstractions.ValueObjects;

namespace DomainDrivenDesign.ValueObjects;

[StringValidation(Pattern = "^[A-Za-z0-9_\\-]{2,32}$")]
public record Username : ValidatableStringValue
{
    public const int MAX_LENGTH = 32;
    public Username(string value) : base(value)
    {
    }
}
