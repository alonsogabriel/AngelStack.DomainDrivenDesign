using AngelStack.DomainDrivenDesign.Abstractions;
using AngelStack.Common.Strings;

namespace DomainDrivenDesign.ValueObjects;

[Required]
[RegularExpression("^[0-9]+$")]
public record Integer(string Value) : StringValidatable(Value);