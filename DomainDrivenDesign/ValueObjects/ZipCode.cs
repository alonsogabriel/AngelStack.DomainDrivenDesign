using AngelStack.DomainDrivenDesign.Abstractions;
using AngelStack.Common.Strings;

namespace DomainDrivenDesign.ValueObjects;

[Required]
[MinLength(1)]
[MaxLength(40)]
[RegularExpression("^[A-Za-z0-9\\-\\.]+$")]
public record ZipCode(string Value) : StringValueValidatable(Value);