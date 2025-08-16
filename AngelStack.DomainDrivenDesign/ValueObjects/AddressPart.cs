using AngelStack.Common.Strings;
using AngelStack.DomainDrivenDesign.Abstractions;

namespace AngelStack.DomainDrivenDesign.ValueObjects;

[Required]
[MinLength(2)]
[MaxLength(80)]
public record AddressPart(string Value) : StringValidatable(Value);