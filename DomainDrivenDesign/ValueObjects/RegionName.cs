using AngelStack.DomainDrivenDesign.Abstractions;
using AngelStack.Common.Strings;

namespace DomainDrivenDesign.ValueObjects;

[Required]
[MinLength(1)]
[MaxLength(80)]
public record RegionName(string Value) : StringValidatable(Value);