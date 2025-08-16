using AngelStack.Common.Strings;
using AngelStack.DomainDrivenDesign.Abstractions;

namespace AngelStack.DomainDrivenDesign.ValueObjects.Brazil;

[Required]
[MaxLength(9)]
[RegularExpression("^[0-9]{9}$")]
public record CnhNumber(string Value) : StringValidatable(Value);