using AngelStack.Common.Strings;
using AngelStack.DomainDrivenDesign.Abstractions;

namespace AngelStack.DomainDrivenDesign.ValueObjects;

[Required]
[MaxLength(3)]
[RegularExpression("^[A-Z]{3}$")]
public record CountryIsoA3(string Value) : StringValidatable(Value.ToUpper());