using AngelStack.Common.Strings;
using AngelStack.DomainDrivenDesign.Abstractions;

namespace AngelStack.DomainDrivenDesign.ValueObjects;

[Required]
[MaxLength(3)]
[RegularExpression("^[0-9]{3}$")]
public record CountryIsoNumber(string Value) : StringValidatable(Value);