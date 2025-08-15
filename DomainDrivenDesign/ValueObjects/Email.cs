using AngelStack.DomainDrivenDesign.Abstractions;
using AngelStack.Common.Strings;

namespace DomainDrivenDesign.ValueObjects;

[Required]
[MaxLength(100)]
[RegularExpression("^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$")]
public record Email(string Value) : StringValueValidatable(Value);