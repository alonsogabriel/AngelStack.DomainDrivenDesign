using System.Reflection;
using AngelStack.Common.Guards;
using AngelStack.Common.Strings;
using AngelStack.DomainDrivenDesign.Abstractions;

namespace AngelStack.DomainDrivenDesign.ValueObjects;

[Required]
[MinLength(2)]
[MaxLength(32)]
public record Username(string Value) : StringValidatable(Value)
{
    public static int? GetMaxLength(Type type)
    {
        var maxLength = type.Guard().GetCustomAttribute<MaxLength>()?.Value;

        return maxLength;
    }
}
