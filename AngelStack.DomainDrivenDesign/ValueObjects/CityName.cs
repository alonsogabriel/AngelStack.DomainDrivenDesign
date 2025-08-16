using AngelStack.Common.Strings;
using AngelStack.DomainDrivenDesign.Abstractions;

namespace AngelStack.DomainDrivenDesign.ValueObjects;

[Required]
[MinLength(2)]
[MaxLength(100)]
public record CityName(string Value) : StringValidatable(Value);