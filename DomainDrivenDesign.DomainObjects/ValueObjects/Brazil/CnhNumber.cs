using DomainDrivenDesign.Abstractions.Attributes;
using DomainDrivenDesign.Abstractions.ValueObjects;

namespace DomainDrivenDesign.DomainObjects.ValueObjects.Brazil;

[StringValidation(Pattern = "^[0-9]{9}$")]
public record CnhNumber : ValidatableStringValue
{
    public const int MAX_LENGTH = 9;
    public CnhNumber(string value) : base(value)
    {
    }
}
