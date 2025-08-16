using AngelStack.Common.Strings;
using AngelStack.DomainDrivenDesign.Abstractions;

namespace AngelStack.DomainDrivenDesign.ValueObjects;

[Required]
[MinLength(1)]
[MaxLength(20)]
public record RegionAlias(string Value) : StringValidatable(Value);