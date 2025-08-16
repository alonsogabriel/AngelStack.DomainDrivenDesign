using AngelStack.DomainDrivenDesign.Abstractions;
using AngelStack.Common.Strings;

namespace DomainDrivenDesign.ValueObjects;

[Required]
[MinLength(8)]
[MaxLength(120)]
public record Street(string Value) : StringValidatable(Value);