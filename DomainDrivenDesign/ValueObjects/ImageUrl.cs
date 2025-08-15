using AngelStack.Common.Strings;
using AngelStack.DomainDrivenDesign.Abstractions;

namespace DomainDrivenDesign.ValueObjects;

[Required]
[MaxLength(500)]
public record ImageUrl(string Value) : StringValueValidatable(Value);