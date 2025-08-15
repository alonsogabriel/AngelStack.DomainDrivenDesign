using AngelStack.Common.Strings;
using AngelStack.DomainDrivenDesign.Abstractions;

namespace DomainDrivenDesign.ValueObjects;

[Required]
[MaxLength(100)]
public record ImageName(string Value) : StringValueValidatable(Value);