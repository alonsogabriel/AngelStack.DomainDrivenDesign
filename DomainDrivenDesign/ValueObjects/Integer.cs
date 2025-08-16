using AngelStack.Common.Strings;
using AngelStack.DomainDrivenDesign.Abstractions;

namespace AngelStack.DomainDrivenDesign.ValueObjects;

[Required]
[RegularExpression("^[0-9]+$")]
public record Integer(string Value) : StringValidatable(Value);