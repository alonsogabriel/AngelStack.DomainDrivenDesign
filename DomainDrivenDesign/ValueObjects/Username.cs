using AngelStack.DomainDrivenDesign.Abstractions;
using AngelStack.Common.Strings;
using AngelStack.Common.Guards;
using System.Reflection;

namespace DomainDrivenDesign.ValueObjects;

[Required]
[MinLength(2)]
[MaxLength(32)]
public record Username(string Value) : StringValueValidatable(Value)
{
    public static int? GetMaxLength(Type type)
    {
        var maxLength = type.Guard().GetCustomAttribute<MaxLength>()?.Value;

        return maxLength;
    }
}
