using AngelStack.DomainDrivenDesign.Abstractions;
using AngelStack.Common.Strings;

namespace DomainDrivenDesign.ValueObjects;

[Required]
[MaxLength(10)]
[RegularExpression("^[0-9]{1,10}$")]
public record AreaCode(string Value) : StringValueValidatable(Value);