using AngelStack.Common.Strings;
using AngelStack.DomainDrivenDesign.Abstractions;

namespace DomainDrivenDesign.ValueObjects;

[MinLength(MIN_LENGTH)]
[MaxLength(MAX_LENGTH)]
[RegularExpression("^[A-Za-z0-9\\-]+$")]
public record AddressNumber : StringValueValidatable
{
    public const int MIN_LENGTH = 1;
    public const int MAX_LENGTH = 20;
    public AddressNumber(string value) : base(value) { }
}
