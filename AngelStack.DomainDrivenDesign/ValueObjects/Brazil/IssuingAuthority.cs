using AngelStack.Common.Strings;
using AngelStack.DomainDrivenDesign.Abstractions;

namespace AngelStack.DomainDrivenDesign.ValueObjects.Brazil;

[Required]
[MinLength(1)]
[MaxLength(40)]
public record IssuingAuthority(string Value) : StringValidatable(Value);