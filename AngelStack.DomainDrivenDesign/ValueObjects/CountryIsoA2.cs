using AngelStack.Common.Strings;
using AngelStack.DomainDrivenDesign.Abstractions;

namespace AngelStack.DomainDrivenDesign.ValueObjects;

[Required]
[MaxLength(2)]
[RegularExpression("^[A-Z]{2}$")]
public record CountryIsoA2(string Value) : StringValidatable(Value.ToUpper());