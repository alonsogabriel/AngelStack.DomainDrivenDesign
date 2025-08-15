using AngelStack.DomainDrivenDesign.Abstractions;
using AngelStack.Common.Strings;

namespace DomainDrivenDesign.ValueObjects;

[Required]
[MinLength(2)]
[MaxLength(100)]
public record CityName(string Value) : StringValueValidatable(Value);