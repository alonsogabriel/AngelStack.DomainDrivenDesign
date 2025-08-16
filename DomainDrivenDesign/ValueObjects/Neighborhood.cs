using AngelStack.Common.Strings;
using AngelStack.DomainDrivenDesign.Abstractions;

namespace AngelStack.DomainDrivenDesign.ValueObjects;

[Required]
[MinLength(1)]
[MaxLength(80)]
public record Neighborhood(string Value) : StringValidatable(Value);