using AngelStack.DomainDrivenDesign.Abstractions;
using AngelStack.Common.Strings;

namespace DomainDrivenDesign.ValueObjects;

[Required]
[MinLength(8)]
[MaxLength(120)]
public record AddressDetails(string Value) : StringValueValidatable(Value);