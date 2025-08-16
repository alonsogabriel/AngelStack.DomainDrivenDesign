using AngelStack.Common.Strings;
using AngelStack.DomainDrivenDesign.Abstractions;

namespace AngelStack.DomainDrivenDesign.ValueObjects;

[Required]
[MinLength(1)]
[MaxLength(20)]
[RegularExpression("^[A-Za-z0-9\\-]+$")]
public record AddressNumber(string Value) : StringValidatable(Value);