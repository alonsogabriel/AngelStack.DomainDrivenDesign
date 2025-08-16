using AngelStack.Common.Strings;
using AngelStack.DomainDrivenDesign.Abstractions;

namespace AngelStack.DomainDrivenDesign.ValueObjects;

[Required]
[MaxLength(10)]
[RegularExpression("^[0-9]{1,10}$")]
public record AreaCode(string Value) : StringValidatable(Value);