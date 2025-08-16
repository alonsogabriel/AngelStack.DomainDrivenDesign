using AngelStack.Common.Strings;
using AngelStack.DomainDrivenDesign.Abstractions;

namespace AngelStack.DomainDrivenDesign.ValueObjects;

[Required]
[MinLength(8)]
[MaxLength(120)]
public record Street(string Value) : StringValidatable(Value);