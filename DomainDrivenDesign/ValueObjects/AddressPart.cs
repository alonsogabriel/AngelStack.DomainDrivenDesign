using AngelStack.DomainDrivenDesign.Abstractions;
using AngelStack.Common.Strings;

namespace DomainDrivenDesign.ValueObjects;

[Required]
[MinLength(2)]
[MaxLength(80)]
public record AddressPart(string Value) : StringValidatable(Value);